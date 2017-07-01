using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;

namespace Manny.IoT.DeviceSimulator
{
    /// <summary>
    /// The purpose of this class is to define metadata/properties/ranges of a telemetry measurement of type string
    /// The focus of this class is more on patterns rather than reading
    /// Data point is in this format {precending number} & {main number} & {trailing number}
    /// </summary>
    public class StringDataPoint : DataPoint, IDataPoint
    {
        public Range Preceding { get; set; }
        public Range Main { get; set; }
        public Range Trailing { get; set; }

        public TelemetryReading Next()
        {

            var nextVal = $"{AppBuilder.Instance.Randomiser.Next(Preceding.Start, Preceding.End)}"+
                            $"{AppBuilder.Instance.Randomiser.Next(Main.Start, Main.End)}"+
                            $"{AppBuilder.Instance.Randomiser.Next(Trailing.Start, Trailing.End)}";

            return new StringReading { ReadingValue = nextVal, MetaData = Measurement };
        }
    }

    public struct Range
    {
        public int Start; public int End;
        public Range(int s, int e)
        {
            Start = s;
            End = e;
        }
    };
}