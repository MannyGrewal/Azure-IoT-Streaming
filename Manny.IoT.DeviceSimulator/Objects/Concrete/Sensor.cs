using System;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Manny.IoT.DeviceSimulator
{
    /// <summary>
    /// This is a concerte class to model a generic sensor
    /// </summary>
    public class Sensor:ISensorActivator
    {
        [JsonProperty("Sensor")]
        public string Name;
        [JsonIgnore]
        public string Key;
        [JsonProperty("DeviceId")]
        public string DeviceNumber;
        [JsonProperty("Lat")]
        public double Lat;
        [JsonProperty("Long")]
        public double Long;
        [JsonIgnore]
        public SelectedConfig AppConfig;
        [JsonIgnore]
        public AppBuilder DefaultConfig;
        [JsonIgnore]
        public RollingWindow WindowInstance;

        public Sensor()
        {
            AppConfig = SelectedConfig.Instance;
            DefaultConfig = AppBuilder.Instance;
            WindowInstance = RollingWindow.Instance;
        }

        public virtual Task Activate()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"Sensor {DeviceNumber} at {Name}. Location is : {Lat}, {Long}";
        }
    }
}
