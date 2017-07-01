using System;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Microsoft.Azure.Devices.Client;
using System.Threading;
using System.Text;

namespace Manny.IoT.DeviceSimulator
{
    /// <summary>
    /// This class models an Phone Call sensor
    /// </summary>
    public class PhoneCallSensor : Sensor
    {
        private StringDataPoint callerUnit;
        private EnumDataPoint<Country> callerCountryUnit;

        public PhoneCallSensor()
        {
            callerUnit = new StringDataPoint { Preceding= new Range(7,9), Main = new Range(100, 99999999), Trailing=new Range(1,9), Measurement = new ReadingMetadata { Name = "Caller Phone"} };
            callerCountryUnit = new EnumDataPoint<Country> {Measurement = new ReadingMetadata { Name = "Call Origin" } };
            callerCountryUnit.Build();
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
                    IncludeSensorHeader=false,
                    Readings = new[] { callerUnit.Next(), callerCountryUnit.Next() }
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
