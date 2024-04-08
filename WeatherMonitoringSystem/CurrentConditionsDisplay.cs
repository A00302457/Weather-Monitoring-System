namespace WeatherMonitoringSystem
{
    public class CurrentConditionsDisplay<T> : IDisplayInterface<string>
    {
        protected IDisplayInterface<T> _idisplayInterface;
        //protected WeatherDataSingleton<T> _weatherDataSingleton;
        
        protected string addInfo;
        public CurrentConditionsDisplay(IDisplayInterface<T> idisplayInterface)
        {
            _idisplayInterface = idisplayInterface;
            addInfo = "";
        }
        public virtual string Display()
        {
            //T? currantData = _idisplayInterface;
            string? currantData = _idisplayInterface.ToString();
            string adddate = $"{DateTime.Now}";
            // Console.WriteLine($"Current conditions: {currantData} {addInfo}");

            return currantData +"  "+ adddate;
        }
    }
}
