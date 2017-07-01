using System;
using System.Configuration;

namespace Manny.IoT.DeviceSimulator
{
    /// <summary>
    /// This class helps in bringing all the commonly used parameters from Config/Input into 
    /// In-Memory variables which are used throughout the application
    /// </summary>
    public sealed class AppBuilder
    {
        private static AppBuilder instance = null;
        public string IoTHubUri, IoTHubConnectionString;
        public int DefaultMessageDelayInMilliSeconds;
        public Random Randomiser;
        private static readonly object syncRoot = new object();

        private AppBuilder() {
            //Load all of them at once
            IoTHubUri= ConfigurationManager.AppSettings["IoTHubUri"];
            IoTHubConnectionString = ConfigurationManager.AppSettings["IoTHubConnectionString"];
            DefaultMessageDelayInMilliSeconds =Convert.ToInt32(ConfigurationManager.AppSettings["DefaultMessageDelayInMilliSeconds"]);
            Randomiser = new Random();
        }

        public static AppBuilder Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                        {
                            instance = new AppBuilder();
                        }
                    }
                }
                return instance;
            }
        }

    }
}
