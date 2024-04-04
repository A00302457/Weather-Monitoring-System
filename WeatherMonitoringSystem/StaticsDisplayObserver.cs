namespace WeatherMonitoringSystem
{
    public class StaticsDisplayObserver<T> : IDisplayInterface<string>
    {
       private IDisplayInterface<T>? _idisplayInterface;
        private List<float> temperatures = new List<float>();
       public StaticsDisplayObserver(IDisplayInterface<T> idisplayInterface)
       {
           _idisplayInterface = idisplayInterface;
       }
       public virtual string Display()
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
            return "";
       }

    }
}