using Manny.IoT.DeviceSimulator;
using System.Collections.Generic;

namespace Manny.IoT.EventGenerator
{
    /// <summary>
    /// A single pattern to make config access easy
    /// </summary>
    public class ConfigFactory
    {
        private static ConfigFactory instance;

       public List<Configuration> AllConfig { get; set; }

        #region MassiveInitialiserInside
        //Init all the configuration once this the private construcutor
        private ConfigFactory()
        {
            AllConfig = new List<Configuration>()
            {
                new Configuration { Name="100 milliseconds", Value = "100", Type= ConfigurationType.EventDelay},
                new Configuration { Name="1 second", Value = "1000", Type= ConfigurationType.EventDelay},
                new Configuration { Name="5 seconds", Value = "5000", Type= ConfigurationType.EventDelay},
                new Configuration { Name="10 seconds", Value = "10000", Type= ConfigurationType.EventDelay},
                new Configuration { Name="20 seconds", Value = "20000", Type= ConfigurationType.EventDelay},
                new Configuration { Name="1 minute", Value = "60000", Type= ConfigurationType.EventDelay},

                new Configuration { Name="1 sensor", Value = "1", Type= ConfigurationType.NumberOfSensors},
                new Configuration { Name="2 sensors", Value = "2", Type= ConfigurationType.NumberOfSensors},
                new Configuration { Name="3 sensors", Value = "3", Type= ConfigurationType.NumberOfSensors},
                new Configuration { Name="4 sensors", Value = "4", Type= ConfigurationType.NumberOfSensors},
                new Configuration { Name="5 sensors", Value = "5", Type= ConfigurationType.NumberOfSensors},
                new Configuration { Name="6 sensors", Value = "6", Type= ConfigurationType.NumberOfSensors},
                new Configuration { Name="7 sensors", Value = "7", Type= ConfigurationType.NumberOfSensors},
                new Configuration { Name="8 sensors", Value = "8", Type= ConfigurationType.NumberOfSensors},
                new Configuration { Name="9 sensors", Value = "9", Type= ConfigurationType.NumberOfSensors},
                new Configuration { Name="10 sensors", Value = "10", Type= ConfigurationType.NumberOfSensors},

                new Configuration { Name="Temperature / Humidity", Value = "Environment", Type= ConfigurationType.SensorType},                
                new Configuration { Name="Air Quality", Value = "Air", Type= ConfigurationType.SensorType},
                new Configuration { Name="Water Pollution", Value = "Water", Type= ConfigurationType.SensorType},
                new Configuration { Name="Phone Calls", Value = "Phone", Type= ConfigurationType.SensorType},

            };
        }
        #endregion
        //Singleton pattern
        public static ConfigFactory Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ConfigFactory();
                }
                return instance;
            }
        }
    }
}
