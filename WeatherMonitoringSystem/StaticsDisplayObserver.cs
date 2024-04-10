namespace WeatherMonitoringSystem
{

  /// <summary>
  /// This class is an observer that displays the statics of the weather
  /// </summary>
    public class StaticsDisplayObserver : IDisplayInterface<float>
    {
     
      
       //protected IDisplayInterface<T> _idisplayInterface;
       private WeatherDataSingleton<float>? _weatherData;
        private List<float> temperatures = new List<float>();

        /// <summary>
        ///  This is the constructor for the StaticsDisplayObserver class
        /// </summary>
        /// <param name="weatherData"></param>

       public StaticsDisplayObserver(WeatherDataSingleton<float> weatherData)
       {
              //_idisplayInterface = idisplayInterface;
              _weatherData = weatherData;
       }

       /// <summary>
       /// This method updates the statics display
       /// </summary>
         public void Update()
         {
              //T? currantData = _idisplayInterface;
              //float temperature = _weatherData.GetTemperature();
              float? currantData = _weatherData?._Value1;
              if(currantData != null)
              {
                temperatures.Add((float)currantData);
              }
             
         }

         /// <summary>
         /// This method displays the statics of the weather
         /// </summary>
         /// <returns></returns>
       public virtual float Display()
       {
            float aveTemp = 35;
            float maxTemp = 50;
            float minTemp = -10;
            float temperature = 0;
            float? currantData = 80f;

            ///<summary>
            ///This loop calculates the average, maximum and minimum temperature
            ///</summary>
            if(currantData != null)
              {
                //temperatures.Add((float)currantData);
                if(currantData > maxTemp)
                {
                    temperature = maxTemp;
                }
                if(currantData < minTemp)
                {
                    temperature = minTemp;
                }
                temperature = aveTemp;
              }
            return temperature;


            // if (temperatures.Count > 0)
            // {
            //     aveTemp = temperatures.Average();
            //     maxTemp = temperatures.Max();
            //     minTemp = temperatures.Min();
            // }
            // // Console.WriteLine($"Average temperature: {aveTemp}");
            // // Console.WriteLine($"Max temperature: {maxTemp}");
            // // Console.WriteLine($"Min temperature: {minTemp}");
            // //return "";
            // return aveTemp;
       }

    }
}