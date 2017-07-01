using Microsoft.Azure.Devices;
using Microsoft.Azure.Devices.Client.Exceptions;
using System;
using System.Threading.Tasks;

namespace Manny.IoT.DeviceSimulator
{
    /// <summary>
    /// This purpose of this class is to register the sensor devices to your IoT Hub.
    /// You typically call this method at the outset of IoT project as this is a once-off operation.
    /// The caller method is commented out, but you can uncomment it when your device information is ready.
    /// Device information and keys go into the Factories\SensorBuilder.cs class
    /// </summary>
    public class RegisterIoTDevices
    {
        public static void RegisterAll()
        {
            //Get all the devices and register them in Azure
            //SensorBuilder.AllSensors.ForEach(loc =>
            //{
            //    Console.WriteLine($"Registering device {loc.ToString()}");
            //    AddDeviceAsync(loc.DeviceNumber).Wait();
            //});
        }
        private static async Task AddDeviceAsync(string deviceId)
        {
            RegistryManager registryManager = RegistryManager.CreateFromConnectionString(AppBuilder.Instance.IoTHubConnectionString);

            Device device;
            try
            {
                device = await registryManager.AddDeviceAsync(new Device(deviceId));
            }
            catch (DeviceAlreadyExistsException)
            {
                device = await registryManager.GetDeviceAsync(deviceId);
            }
            Console.WriteLine("Generated device key: {0}", device.Authentication.SymmetricKey.PrimaryKey);
        }
    }
}