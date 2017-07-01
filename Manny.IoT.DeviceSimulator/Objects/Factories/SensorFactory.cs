using System;
using System.Collections.Generic;
using System.Linq;

namespace Manny.IoT.DeviceSimulator
{
    /// <summary>
    /// A sensor factory based on the UI combobox
    /// </summary>
    public static class SensorFactory
    {
        //private static Dictionary<string, Func<Sensor>> dictSensors = new Dictionary<string, Func<Sensor>>
        //    {
        //        { "Temperature", () => new EnvironmentSensor() },
        //         { "Air", () => new AirQualitySensor() },
        //         { "Water", () => new WaterLevelSensor() },
        //         { "Phone", () => new PhoneCallSensor() }
        //    };

        private static Dictionary<string, Type> dictSensors = new Dictionary<string, Type>
            {
                { "Environment", typeof(EnvironmentSensor) },
                 { "Air", typeof(AirQualitySensor) },
                 { "Water", typeof(WaterPollutionSensor) },
                 { "Phone", typeof(PhoneCallSensor) }
            };


        public static Type ConstructSensor(string id)
        {
            return dictSensors[id];
        }
    }
}
