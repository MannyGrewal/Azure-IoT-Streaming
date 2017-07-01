using System;
using System.Collections.Generic;
using System.Linq;

namespace Manny.IoT.DeviceSimulator
{
    /// <summary>
    /// This class facilitates a pre-defined list of sensors location in Melbourne Region
    /// Lat and Long helps in mapping the sensors e.g. on a Power BI map
    /// Key comes from the IoT Hub's Registered Controllers - <you need add your own key>
    /// </summary>
    public class SensorBuilder<T> where T:Sensor, new()
    {
        #region Pre-defined list of sensors
        private static List<T> AllSensors = new List<T>(){
            new T { DeviceNumber="G024", Name = "Doncaster", Lat = -37.785466, Long = 145.1240296, Key= "xxxx-xxxx" },
            new T { DeviceNumber="K935",Name = "Sunshine", Lat = -37.7865, Long = 144.8319, Key= "xxxx-xxxx" },
            new T { DeviceNumber="F702",Name = "Dandenong", Lat = -37.9875, Long = 145.2149, Key= "xxxx-xxxx"  },
            new T { DeviceNumber="I524",Name = "Werribee", Lat = -37.9029, Long = 144.6585, Key= "xxxx-xxxx"  },
            new T { DeviceNumber="A164",Name = "Derrimut", Lat = -37.7955, Long = 144.7714, Key= "xxxx-xxxx"  },
            new T { DeviceNumber="B134",Name = "Frankston", Lat = -38.1414, Long = 145.1225, Key= "xxxx-xxxx"  },
            new T { DeviceNumber="Z084",Name = "Craigieburn", Lat = -37.5984, Long = 144.9418, Key= "xxxx-xxxx"  },
            new T { DeviceNumber="Y664",Name = "Ringwood", Lat = -37.8143, Long = 145.2274, Key= "xxxx-xxxx"  },
            new T { DeviceNumber="G543",Name = "Berwick", Lat = -38.0309, Long = 145.3461, Key= "xxxx-xxxx"  },
            new T { DeviceNumber="K224",Name = "Kew", Lat = -37.8068, Long = 145.031, Key= "xxxx-xxxx"  }
        };
        #endregion

        /// <summary>
        /// Seed 10 sensors at common locations in Melbourne Metro, VIC
        /// </summary>
        /// <returns></returns>
        private T[] SeedSensorsAtLocations()
        {
            return AllSensors.ToArray();
        }

        /// <summary>
        /// This method gives you N randomly selected sensors from the predefined list of sensors.
        /// </summary>
        /// <param name="howMany">How many sensors to ramdomly select from the list, Max 10</param>
        /// <returns>Randomly selected sensors</returns>
        public T[] GetSensors(int howMany = 5)
        {
            var allSensors = SeedSensorsAtLocations();
            int totalSensors = allSensors.Length;
            
            var randomSensors = new T[howMany];            
            for (int i = 0; i < howMany; i++)
            {                
                int next = (int) Math.Floor(AppBuilder.Instance.Randomiser.NextDouble() * totalSensors--);
                randomSensors[i] = allSensors[next];

                //Remove the selected element from the array, for this we need to convert it to a list and re-Array
                // May not be the most efficient way but does the job :)
                var listLocations = allSensors.ToList();
                listLocations.RemoveAt(next);
                allSensors = listLocations.ToArray();
            }

            return randomSensors;
        }

    }
}
