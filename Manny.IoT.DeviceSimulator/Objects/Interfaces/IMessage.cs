using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Manny.IoT.DeviceSimulator
{
    /// <summary>
    /// Interface to model creation behaviour of a general message
    /// </summary>
    public interface IMessage
    {
        Guid MessageId { get; }
        DateTime EmittedOn { get; }
        Sensor SensorDataHeader { get; }

        string SpecialMessage { get; }

        IList<TelemetryReading> Readings { get; }

        string ToString();
    }
}
