namespace Manny.IoT.DeviceSimulator
{
    /// <summary>
    /// Objects related to the Configuration screen
    /// </summary>
    public class Configuration
    {
      
       public string Name { get; set; }
       public string Value { get; set; }
       public ConfigurationType Type { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
