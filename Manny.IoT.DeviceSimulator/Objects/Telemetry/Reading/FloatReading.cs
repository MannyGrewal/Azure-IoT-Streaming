using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;

namespace Manny.IoT.DeviceSimulator
{
    /// <summary>
    /// Float Readings
    /// </summary>
    public class FloatReading : TelemetryReading
    {
        public float ReadingValue { get; set; }

        public override string ToString()
        {
            string alert = (Level == AlertLevel.Critical) ? " Alert Level=Critical" : string.Empty;
            return $"  {MetaData.Name} = {ReadingValue:0.##}{MetaData.Unit}{alert}";
        }
    }
}
