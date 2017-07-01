using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;

namespace Manny.IoT.DeviceSimulator
{
    /// <summary>
    /// The purpose of this class is to define metadata/properties/ranges of a telemetry measurement of type float
    /// </summary>
    public class FloatDataPoint: DataPoint, IDataPoint
    {
        //Min value of a data point
        public float MinValue { get; set; } = 0.0f;

        //Max value of a data point
        public float MaxValue { get; set; } = 100.0f;

        //General value, common value
        public float CommonValue { get; set; } = 50.0f;

        //This is how much you want the value to fluctuate on either side of the Common Value
        public float FluctuationPercentage { get; set; } = 20.0f;
        public float MinThreshold { get; set; } = 0.0f;
        public float MaxThreshold { get; set; } = 0.0f;

        //At what percentage of the MaxValue, the reading should be flagged as an Alert/Critical
        public float AlertThresholdPercentage { get; set; } = 80.0f;

        public void Build()
        {
            if (MinThreshold == 0.0f)
                (MinThreshold, MaxThreshold) = InitialiseThresholds();
        }

        public TelemetryReading Next()
        {
            var nextVal = (float)AppBuilder.Instance.Randomiser.NextDouble() * (MaxThreshold - MinThreshold) + MinThreshold;
            var alertLevel = (nextVal > AlertThresholdPercentage * .01f * MaxValue) ? AlertLevel.Critical : AlertLevel.Normal;
            return new FloatReading { ReadingValue = nextVal, Level = alertLevel, MetaData= Measurement };
        }

        private (float, float) InitialiseThresholds()
        {
            var diffMin = CommonValue - (FluctuationPercentage * .01f * CommonValue);
            var diffMax = CommonValue + (FluctuationPercentage * .01f * CommonValue);
            return (diffMin > MinValue ? diffMin : MinValue, diffMax < MaxValue ? diffMax : MaxValue);
        }

        
    }
}