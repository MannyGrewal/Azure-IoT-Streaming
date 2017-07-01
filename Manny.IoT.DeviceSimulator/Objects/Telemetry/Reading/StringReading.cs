using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;

namespace Manny.IoT.DeviceSimulator
{
    /// <summary>
    /// Float Readings
    /// </summary>
    public class StringReading : TelemetryReading
    {
        public string ReadingValue { get; set; }

        public override string ToString()
        {
            string alert = (Level == AlertLevel.Critical) ? " Alert Level=Critical" : string.Empty;
            return $"  {MetaData?.Name} = {ReadingValue}{MetaData?.Unit}{alert}";
        }
    }
}
