using System;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Microsoft.Azure.Devices.Client;
using System.Threading;
using System.Text;

namespace Manny.IoT.DeviceSimulator
{
    /// <summary>
    /// This class models an Air Quality sensor
    /// </summary>
    public class AirQualitySensor : Sensor
    {
        //Air Quality Index's measured pollutants (PM10, PM2.5, NO2, SO2, CO, O3, NH3, and Pb)
        //Ranges taken from this article - https://en.wikipedia.org/wiki/Air_quality_index
        //Unit used - micrograms per cubic meter (µg/m3)
        private FloatDataPoint PM10Settings, NO2Settings, COSettings, PbSettings;

        public AirQualitySensor()
        {
            PM10Settings = new FloatDataPoint { MinValue = 0, MaxValue = 500, CommonValue = 100, FluctuationPercentage = 30, Measurement = new ReadingMetadata { Name = "PM10", Unit = "µg/m3" } };
            NO2Settings = new FloatDataPoint { MinValue = 0, MaxValue = 250, CommonValue = 100, FluctuationPercentage = 20, Measurement = new ReadingMetadata { Name = "NO2", Unit = "µg/m3" } };
            COSettings = new FloatDataPoint { MinValue = 0, MaxValue = 35, CommonValue = 9, FluctuationPercentage = 90, Measurement = new ReadingMetadata { Name = "CO", Unit = "µg/m3" } };
            PbSettings = new FloatDataPoint { MinValue = 0, MaxValue = 3.5f, CommonValue = 0.9f, FluctuationPercentage = 15, Measurement = new ReadingMetadata { Name = "Pb", Unit = "µg/m3" } };
            //Build
            PM10Settings.Build();
            NO2Settings.Build();
            COSettings.Build();
            PbSettings.Build();
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
                    Readings = new[] { PM10Settings.Next(), NO2Settings.Next(), COSettings.Next(), PbSettings.Next() }
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
