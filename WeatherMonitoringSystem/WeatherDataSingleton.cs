namespace WeatherMonitoringSystem
{

    /// <summary>
    /// This class is a singleton that holds the weather data
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class WeatherDataSingleton<T> where T : new ()
    {
        private static WeatherDataSingleton<T>? instance;
         private List<IDisplayInterface<T>> WeatherDataObservers = new();
        private static T? _Value;

        /// <summary>
        /// This is the constructor for the WeatherDataSingleton class
        /// </summary>
       
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

        /// <summary>
        /// This method gets the instance of the WeatherDataSingleton class
        /// </summary>
        /// <returns></returns>
       
        public static WeatherDataSingleton<T> GetInstance()
        {
           if (instance == null)
            {
                instance = new WeatherDataSingleton<T>();
            }
            return instance;
        }

        /// <summary>
        /// This method adds an observer to the WeatherDataSingleton class
        /// </summary>
        /// <param name="observer"></param>
  
        public void AddObserver(IDisplayInterface<T> observer)
        {
            if(!WeatherDataObservers.Contains(observer))
            {
                WeatherDataObservers.Add(observer);
            }
        }


        /// <summary>
        /// This method removes an observer from the WeatherDataSingleton class
        /// </summary>
        /// <param name="observer"></param>
        public void RemoveObserver(IDisplayInterface<T> observer)
        {
            if(WeatherDataObservers.Contains(observer))
            {
                WeatherDataObservers.Remove(observer);
            }
        }


        /// <summary>
        /// This method notifies the observers
        /// </summary>
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
