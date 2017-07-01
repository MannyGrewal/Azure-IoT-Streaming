using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;

namespace Manny.IoT.DeviceSimulator
{
    /// <summary>
    /// This class defines the DTO for the Phone call message
    /// </summary>
    public class PhoneCallMessage : TelemetryMessage
    { 
        public Country Origin;
        public Country Destination;
        public float Duration;
        public string CallerIMSI;
        public string CallPhoneNumber;
        public string CalleePhoneNumber;
      
        public override string ToString()
        {
            return $"Sensor {SensorDataHeader.DeviceNumber} at {SensorDataHeader.Name} -> ";
        }
    }
}
