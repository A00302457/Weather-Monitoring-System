
namespace WeatherMonitoringSystem
{
    /// <summary>
    /// This class is an observer that displays the forecast of the weather
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ForecastDisplayObserver<T> : IDisplayInterface<float>
    {
        //protected IDisplayInterface<T> _idisplayInterface;
        private WeatherDataSingleton<float>? _weatherData;
        protected string addInfo;
        private float _currentPressure = 29.92f;
        private float _lastPressure= 29.92f;

        /// <summary>
        /// This is the constructor for the ForecastDisplayObserver class
        /// </summary>
        /// <param name="weatherData"></param>
        public ForecastDisplayObserver(WeatherDataSingleton<float> weatherData)
        {
            //_idisplayInterface = idisplayInterface;
            _weatherData = weatherData;
            addInfo = "";
        }
        
        /// <summary>
        /// This method updates the forecast display
        /// </summary>
        /// <returns></returns>
        public virtual float Display()
        {
           //string forecast = "Forecast: ";
            if (_currentPressure > _lastPressure)
            {
                Console.WriteLine("forecast = Improving weather on the way!");
                return _currentPressure;
                
            }
            else if (_currentPressure == _lastPressure)
            {
                Console.WriteLine("forecast = More of the same");
                return _currentPressure;
            }
            else if (_currentPressure < _lastPressure)
            {
                Console.WriteLine("forecast = Watch out for cooler, rainy weather");
                return _currentPressure;
            }
            //return forecast;
           
            return _currentPressure;
        }
    }
}