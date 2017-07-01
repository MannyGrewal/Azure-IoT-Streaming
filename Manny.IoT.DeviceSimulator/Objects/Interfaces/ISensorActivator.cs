using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Threading.Tasks;

namespace Manny.IoT.DeviceSimulator
{
    /// <summary>
    /// Interface to model activation behaviour of a general sensor
    /// </summary>
    public interface ISensorActivator
    {
        Task Activate();
    }
}
