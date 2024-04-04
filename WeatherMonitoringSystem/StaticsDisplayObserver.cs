namespace WeatherMonitoringSystem
{
    public class StaticsDisplayObserver<T> : IDisplayInterface
    {
       private IDisplayInterface? _idisplayInterface;
        private List<float> temperatures = new List<float>();
       public StaticsDisplayObserver(IDisplayInterface idisplayInterface)
       {
           _idisplayInterface = idisplayInterface;
       }
       public virtual void Display()
       {
            float aveTemp = 0;
            float maxTemp = 0;
            float minTemp = 0;
            if (temperatures.Count > 0)
            {
                aveTemp = temperatures.Average();
                maxTemp = temperatures.Max();
                minTemp = temperatures.Min();
            }
            Console.WriteLine($"Average temperature: {aveTemp}");
            Console.WriteLine($"Max temperature: {maxTemp}");
            Console.WriteLine($"Min temperature: {minTemp}");
            //return "";
       }

    }
}