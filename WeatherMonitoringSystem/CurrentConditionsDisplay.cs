namespace WeatherMonitoringSystem
{
    public abstract class CurrentConditionsDisplay<T> : IDisplayInterface
    {
        protected IDisplayInterface _idisplayInterface;
        //protected WeatherDataSingleton<T> _weatherDataSingleton;
        
        protected string addInfo;
        public CurrentConditionsDisplay(IDisplayInterface idisplayInterface)
        {
            _idisplayInterface = idisplayInterface;
            addInfo = "";
        }
        public virtual void Display()
        {
            //T currantData = _idisplayInterface;
            string? currantData = _idisplayInterface.ToString();
            string adddate = $"{DateTime.Now}";
            Console.WriteLine($"Current conditions: {currantData} {addInfo}");

            //return adddate;
        }
    }
}