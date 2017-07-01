using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Threading.Tasks;

namespace Manny.IoT.DeviceSimulator
{
    /// <summary>
    /// Interface to model creation behaviour of a general datapoints
    /// </summary>
    public interface IDataPoint
    {       
        TelemetryReading Next(); 
    }
}
