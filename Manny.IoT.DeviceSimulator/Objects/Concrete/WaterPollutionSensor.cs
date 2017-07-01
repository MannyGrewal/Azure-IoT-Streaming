using System;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Microsoft.Azure.Devices.Client;
using System.Threading;
using System.Text;

namespace Manny.IoT.DeviceSimulator
{
    /// <summary>
    /// This class models an Water Level sensor
    /// </summary>
    public class WaterPollutionSensor : Sensor
    {
        private FloatDataPoint waterLevelUnit, waterpHUnit, waterDissolvedOxygenUnit, waterORPUnit;

        public WaterPollutionSensor()
        {
            waterLevelUnit = new FloatDataPoint { MinValue = 0, MaxValue = 5000, CommonValue = 2500, FluctuationPercentage = 30, Measurement = new ReadingMetadata { Name = "Water Level", Unit = "mm" } };
            waterpHUnit = new FloatDataPoint { MinValue = 0, MaxValue = 14, CommonValue = 4, FluctuationPercentage = 30, Measurement = new ReadingMetadata { Name = "Alkalinity", Unit = "pH" } };
            waterDissolvedOxygenUnit = new FloatDataPoint { MinValue = 0, MaxValue = 100, CommonValue = 40, FluctuationPercentage = 20, Measurement = new ReadingMetadata { Name = "Dissolved Oxygen Saturation", Unit = "%" } };
            waterORPUnit = new FloatDataPoint { MinValue = -700, MaxValue = 700, CommonValue = 300, FluctuationPercentage = 40, Measurement = new ReadingMetadata { Name = "Oxygen Reduction Potential", Unit = "mV" } };
            waterLevelUnit.Build();
            waterpHUnit.Build();
            waterDissolvedOxygenUnit.Build();
            waterORPUnit.Build();
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
                    Readings = new[] { waterLevelUnit.Next(), waterpHUnit.Next(), waterDissolvedOxygenUnit.Next(), waterORPUnit.Next() }
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
