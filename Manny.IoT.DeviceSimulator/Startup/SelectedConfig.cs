using System.Threading;

namespace Manny.IoT.DeviceSimulator
{
    /// <summary>
    /// This object will store the configuration selected in the App's UI
    /// </summary>
    public class SelectedConfig
    {

        public Configuration DelayInEvents { get; set; }
        public Configuration NumSensors { get; set; }
        public Configuration SensorType { get; set; }
        public bool IsCurrentlyStreaming { get; set; }

        //If more than one sensors are emitting messages, setting this property will ensure 
        //that all the sensors do not emit at the same time
        public bool RandomiseMessageEmissionTime { get; set; }
        public CancellationTokenSource CancelStreamingToken { get; set; }

        private static SelectedConfig instance;

        private SelectedConfig()
        {
        }

        public static SelectedConfig Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SelectedConfig();
                }
                return instance;
            }
        }
    }
}
