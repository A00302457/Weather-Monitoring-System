namespace WeatherMonitoringSystem
{
    public class WeatherDataSingleton<T> where T : new ()
    {
         private List<IDisplayInterface> WeatherDataObservers = new();
        private T? _Value;
       
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
       
        public WeatherDataSingleton()
        {

        }
        public void AddObserver(IDisplayInterface observer)
        {
            if(!WeatherDataObservers.Contains(observer))
            {
                WeatherDataObservers.Add(observer);
            }
        }
        public void RemoveObserver(IDisplayInterface observer)
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
        //     if(_instance != null)
        //     {
        //         return _instance;
        //     }
            
        //     _instance = new();
        //     return _instance;
        // }
    }
}
