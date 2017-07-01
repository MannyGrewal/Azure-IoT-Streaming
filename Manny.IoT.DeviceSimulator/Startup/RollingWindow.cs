namespace Manny.IoT.DeviceSimulator
{
    /// <summary>
    /// This object will store the configuration selected in the App's UI
    /// </summary>
    public class RollingWindow
    {
      
       public MessageCollection Messages { get; set; }

        private static RollingWindow instance;
      
        private RollingWindow()
        {
            Messages = new MessageCollection();
        }

        public static RollingWindow Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new RollingWindow();
                }
                return instance;
            }
        }
    }
}
