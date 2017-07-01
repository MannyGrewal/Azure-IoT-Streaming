using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections;
using System.Configuration;

namespace Manny.IoT.DeviceSimulator
{
    /// <summary>
    /// Running Collection of the messages. 
    /// It is rolling window collection to store temporal messages. 
    /// Default size is 20 as defined in the Config
    /// </summary>
    public class MessageCollection : CollectionBase
    {
        private readonly int rollingWindowSize = Convert.ToInt32(ConfigurationManager.AppSettings["MessagesRollingWindowSize"]);
        private readonly object syncRoot = new object();
        public int TotalMessages = 0;
       
        public TelemetryMessage this[int index]
        {
            get
            {
                return (TelemetryMessage) base.List[index];
            }
            set
            {
                base.List[index] = value;
            }
        }
        public void Add(TelemetryMessage message)
        {
            //Addition thread safety
            lock (syncRoot)
            {
                if (base.List.Count > rollingWindowSize)
                    base.List.RemoveAt(0);
                base.List.Add(message);
                TotalMessages++;
            }
                
        }
    }
}
