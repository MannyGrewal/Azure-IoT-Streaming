using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;

namespace Manny.IoT.DeviceSimulator
{
    /// <summary>
    /// The purpose of this class is to define metadata/properties/ranges of a telemetry measurement of type list/enum/set
    /// The focus of this class is more on patterns rather than reading
    /// Data point is in this format {precending number} & {main number} & {trailing number}
    /// </summary>
    public class EnumDataPoint<T> : DataPoint, IDataPoint where T : IConvertible
    {
        private string[] allValues;
        public void Build()
        {
            allValues = Enum.GetNames(typeof(T));
            Array.Sort(allValues);
        }

        public TelemetryReading Next()
        {

            var nextVal = $"{allValues.GetValue(AppBuilder.Instance.Randomiser.Next(allValues.GetLowerBound(0), allValues.GetUpperBound(0)))}";

            return new StringReading { ReadingValue = nextVal, MetaData = Measurement };
        }
    }
}