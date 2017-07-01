using System;

namespace Manny.IoT.DeviceSimulator
{
    /// <summary>
    /// Objects related to the Configuration screen
    /// </summary>
    public static class ExtensionMethods
    {
      /// <summary>
      /// Get the int value out of the Config record
      /// -1 otherwise
      /// </summary>
      public static int GetIntValue(this Configuration config)
        {
            if (config != null && config.Value != null)
                return Convert.ToInt32(config.Value);
            else
                return -1;
        }
    }
}
