using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;

namespace Manny.IoT.DeviceSimulator
{
    /// <summary>
    /// Base Datapoint
    /// </summary>
    public class DataPoint
    {
        public ReadingMetadata Measurement { get; set; }
    }
}