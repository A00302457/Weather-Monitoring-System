namespace WeatherMonitoringSystem
{
    public class WeatherDataSingleton<T> where T : new ()
    {
        private static T? _instance;
        public WeatherDataSingleton()
        {

        }
        public T GetInstance()
        {
            if(_instance != null)
            {
                return _instance;
            }
            
            _instance = new();
            return _instance;
        }
    }
}
