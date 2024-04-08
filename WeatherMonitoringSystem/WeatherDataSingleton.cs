namespace WeatherMonitoringSystem
{
    public class WeatherDataSingleton<T> where T : new ()
    {
        private static WeatherDataSingleton<T>? instance;
         private List<IDisplayInterface<T>> WeatherDataObservers = new();
        private static T? _Value;
       
        public T? _Value1
        {
            get
            {
                return _Value;
            }
            set
            {
                _Value = value;
                NotifyObservers();
            }
        } 
       
        public static WeatherDataSingleton<T> GetInstance()
        {
           if (instance == null)
            {
                instance = new WeatherDataSingleton<T>();
            }
            return instance;
        }
  
        public void AddObserver(IDisplayInterface<T> observer)
        {
            if(!WeatherDataObservers.Contains(observer))
            {
                WeatherDataObservers.Add(observer);
            }
        }
        public void RemoveObserver(IDisplayInterface<T> observer)
        {
            if(WeatherDataObservers.Contains(observer))
            {
                WeatherDataObservers.Remove(observer);
            }
        }
        public void NotifyObservers()
        {
            foreach (var observer in WeatherDataObservers)
            {
                observer.Display();
            }
        }

        // public T GetInstance()
        // {
        //     if(_Value != null)
        //     {
        //         return _instance;
        //     }
            
        //     _instance = new();
        //     return _instance;
        // }
    }
}
