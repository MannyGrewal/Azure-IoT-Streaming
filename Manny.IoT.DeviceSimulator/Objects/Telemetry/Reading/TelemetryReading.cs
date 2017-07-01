using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;

namespace Manny.IoT.DeviceSimulator
{
    /// <summary>
    /// The purpose of this class is to model the actual reading emitted from a sensor at a particular time
    /// </summary>
    public class TelemetryReading
    { 
        public ReadingMetadata MetaData { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public AlertLevel Level { get; set; } = AlertLevel.Normal;

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
