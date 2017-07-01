//*********************************************************
//
//    Author : Manny Grewal - 2017
//    This code is provided under Open Source License
//    It has not been tested and is not suited for *Production* use  
//    THIS CODE IS PROVIDED *AS IS* WITHOUT WARRANTY OF
//    ANY KIND, EITHER EXPRESS OR IMPLIED, INCLUDING ANY
//    IMPLIED WARRANTIES OF FITNESS FOR A PARTICULAR
//    PURPOSE, MERCHANTABILITY, OR NON-INFRINGEMENT.
//
//*********************************************************

using System;
using System.Linq;
using System.Reflection;

namespace Manny.IoT.DeviceSimulator
{
    public static class Bootstrap
    {

        public static string Main()
        {
            //Default to 4 sensors if not chosen
            int sensorsCount = SelectedConfig.Instance.NumSensors.GetIntValue();
            int totSensors = sensorsCount == -1 ? 4: sensorsCount;
            Activate(totSensors);

            Console.WriteLine(SelectedConfig.Instance.DelayInEvents);

            //Console.ReadLine();

            return SelectedConfig.Instance.DelayInEvents.Value;
        }

        private static void Activate(int numberOfSensors)
        {
            Type sensorType = SensorFactory.ConstructSensor(SelectedConfig.Instance.SensorType.Value);
            //Instantiate generic class using reflection
            Type[] typeArgs = { sensorType };
            var genericType = typeof(SensorBuilder<>).MakeGenericType(typeArgs);
            var genericObject = Activator.CreateInstance(genericType);
            //Inovke method using reflection
            MethodInfo genericMethodInfo = genericType.GetMethod("GetSensors");
            var sensors = (Sensor[]) genericMethodInfo.Invoke(genericObject, new object[] { numberOfSensors });

            sensors.ToList().ForEach(async (s) =>
               {
                   await s.Activate();
               });
        }
    }
}
