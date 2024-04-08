// 
namespace WeatherMonitoringSystem
{
    public class ForecastDisplayObserver<T> : IDisplayInterface<string>
    {
        protected IDisplayInterface<T> _idisplayInterface;
        protected string addInfo;
        public ForecastDisplayObserver(IDisplayInterface<T> idisplayInterface)
        {
            _idisplayInterface = idisplayInterface;
            addInfo = "";
        }
        public virtual string Display()
        {
            string? currantData = _idisplayInterface.ToString();
            string adddate = $"{DateTime.Now}";
            // Console.WriteLine($"Forecast: {currantData} {addInfo}");
            // return adddate;
            return currantData +"  "+ adddate;
        }
    }
}