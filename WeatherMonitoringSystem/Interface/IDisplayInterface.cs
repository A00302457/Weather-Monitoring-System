/// <summary>
/// This interface is used to display the weather data
/// </summary>

namespace WeatherMonitoringSystem
{

    /// <summary>
    /// This interface is used to display the weather data
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IDisplayInterface<T>
    {
        /// <summary>
        /// This method is used to display the weather data
        /// </summary>
        /// <returns></returns>
        public T Display();
    }
 
}