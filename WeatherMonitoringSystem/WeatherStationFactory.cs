namespace WeatherMonitoringSystem
{
    public class WeatherStationFactory
    {
       public IDisplayInterface CreateWeatherStation(string type, WeatherDataSingleton<T> weatherDataSingleton)
        {
            IDisplayInterface? weatherStation = null;
            switch (type)
            {
                case "CurrentConditionsDisplay":
                    weatherStation = new CurrentConditionsDisplay(weatherDataSingleton);
                    break;
                case "StatisticsDisplay":
                    weatherStation = new StatisticsDisplay(weatherDataSingleton);
                    break;
                case "ForecastDisplay":
                    weatherStation = new ForecastDisplay(weatherDataSingleton);
                    break;
                default:
                    throw new ArgumentException("Invalid weather station type");
            }
            return weatherStation;
        }
    }
}