using System;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Microsoft.Azure.Devices.Client;
using System.Threading;
using System.Text;
using System.Collections.Generic;

namespace Manny.IoT.DeviceSimulator
{
    /// <summary>
    /// This class models an Environment (Temperature/Humidity) sensor
    /// </summary>
    public class EnvironmentSensor : Sensor
    {
        private FloatDataPoint temperatureUnit, humidityUnit;

        public EnvironmentSensor()
        {  
            temperatureUnit = new FloatDataPoint { MinValue = 0, MaxValue = 50, CommonValue = 30, FluctuationPercentage = 10, Measurement = new ReadingMetadata { Name = "Temperature", Unit = "C" } };
            humidityUnit = new FloatDataPoint { MinValue = 20, MaxValue = 80, CommonValue = 50, FluctuationPercentage = 30, Measurement = new ReadingMetadata { Name = "Humidity", Unit = "RH" } };
            temperatureUnit.Build();
            humidityUnit.Build();
        }
        public async override Task Activate()
        {
            Console.WriteLine($"Activating device {Name.ToString()} ......");

            var deviceClient = DeviceClient.Create(DefaultConfig.IoTHubUri,
                                    new DeviceAuthenticationWithRegistrySymmetricKey(DeviceNumber, Key), TransportType.Mqtt);

            int selectedVal = AppConfig.DelayInEvents.GetIntValue();
            int delay = (selectedVal == -1) ? DefaultConfig.DefaultMessageDelayInMilliSeconds : selectedVal;


            while (true)
            {
                //Stop if cancellation has been requested
                if (AppConfig.CancelStreamingToken.IsCancellationRequested)
                    break;

                //RandomiseEmissionTime ensures message generation is scattered across the interval window (not all at the same time)
                if (AppConfig.RandomiseMessageEmissionTime)
                {
                    Thread.Sleep(AppBuilder.Instance.Randomiser.Next(0, delay));
                }

                var telemetryDataPoint = new TelemetryMessage
                {
                    SensorDataHeader = this,
                    Readings = new[]{ temperatureUnit.Next(), humidityUnit.Next() }
                };
              

                var jsonString = telemetryDataPoint.JSONSerialisedMessage();
                var message = new Message(Encoding.ASCII.GetBytes(jsonString));
                //message.Properties.Add("level", levelValue);

                Console.WriteLine("{0} > Sending message: {1}", DateTime.Now, jsonString);
                await deviceClient.SendEventAsync(message);
                //Add the message to the collection
                WindowInstance.Messages.Add(telemetryDataPoint);

                await Task.Delay(delay);
            }
        }
    }
}
