namespace WeatherMonitoringSystem.WeatherDataSingleton
{
    public class Singleton<T> where T : new ()
    {
        private static T? _instance;
        public Singleton()
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
