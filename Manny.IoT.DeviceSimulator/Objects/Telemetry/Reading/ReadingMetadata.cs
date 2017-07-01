using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;

namespace Manny.IoT.DeviceSimulator
{
    /// <summary>
    /// General metadata about readings
    /// </summary>
    public class ReadingMetadata
    {
        public string Name { get; set; }
        public string Unit { get; set; }
    }
}
