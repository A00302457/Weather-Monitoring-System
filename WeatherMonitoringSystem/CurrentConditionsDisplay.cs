namespace WeatherMonitoringSystem
{
    public abstract class CurrentConditionsDisplay<T> : IDisplayInterface<T>
    {
        protected IDisplayInterface<T> _idisplayInterface;
        protected string addInfo;
        public CurrentConditionsDisplay(IDisplayInterface<T> idisplayInterface)
        {
            _idisplayInterface = idisplayInterface;
            addInfo = "";
        }
        public virtual T Display()
        {
            T currantData = _idisplayInterface.Display();
            string adddate = $"{DateTime.Now}";

            return (T)adddate;
        }
    }
}