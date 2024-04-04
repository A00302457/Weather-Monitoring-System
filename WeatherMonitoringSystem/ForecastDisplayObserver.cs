namespace WeatherMonitoringSystem
{
    public class ForecastDisplayObserver<T> : IDisplayInterface
    {
       // private WeatherDataSingleton<T> _weatherDataSingleton;
        private IDisplayInterface? _idisplayInterface;
        public ForecastDisplayObserver(IDisplayInterface idisplayInterface)
        {
            _idisplayInterface = idisplayInterface;
        }
        public virtual void Display()
        {
            Random random = new Random();
            string[] forecasts = new string[] { "Sunny", "Rainy", "Cloudy", "Snowy","Windy","Foggy","Hazy","Thunderstorm" };
            string forecast = forecasts[random.Next(0, forecasts.Length)];
            Console.WriteLine($"Forecast: {forecast}");
        }

    }
}