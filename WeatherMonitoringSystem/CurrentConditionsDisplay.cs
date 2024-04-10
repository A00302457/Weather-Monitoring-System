// Purpose: This class is an observer that displays the current conditions of the weather.
namespace WeatherMonitoringSystem
{
    /// <summary>
    /// This class is an observer that displays the current conditions of the weather
    /// </summary>
    public class CurrentConditionsDisplay : IDisplayInterface<float>
    {
       // protected IDisplayInterface<string> _idisplayInterface;
         private WeatherDataSingleton<float>? _weatherData;
        //protected WeatherDataSingleton<T> _weatherDataSingleton;
        
        protected string addInfo;

        /// <summary>
        /// This is the constructor for the CurrentConditionsDisplay class
        /// </summary>
        /// <param name="weatherData"></param>
        public CurrentConditionsDisplay(WeatherDataSingleton<float> weatherData)
        {
            //_idisplayInterface = idisplayInterface;
            _weatherData = weatherData;
            addInfo = "";
        }
       
       /// <summary>
       /// This method updates the current conditions display
       /// </summary>
       /// <returns></returns>
        public virtual float Display()
        {
            float? currantData = _weatherData?._Value1;
            string adddate = $"{DateTime.Now}";
            return currantData ?? 0;
        }
    }
}
