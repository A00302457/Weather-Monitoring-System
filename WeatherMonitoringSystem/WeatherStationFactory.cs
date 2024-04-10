namespace WeatherMonitoringSystem
{


    /// <summary>
    /// This class is a factory that creates displays
    /// </summary>
    public class WeatherStationFactory
    {

        /// <summary>
        /// This method creates a display
        /// </summary>
        /// <param name="displayType"></param>
        /// <param name="weatherData"></param>
        /// <returns></returns>
       public static IDisplayInterface<float> CreateDisplay(string displayType, WeatherDataSingleton<float> weatherData)
        {
            switch (displayType)
            {
                case "current":
                    return new CurrentConditionsDisplay(weatherData);
                 case "forecast":
                     return new ForecastDisplayObserver<float>(weatherData);
                 case "statics":
                    return new StaticsDisplayObserver(weatherData);
                 default:
                    return new CurrentConditionsDisplay(weatherData);
            }
        }

    }
}

      