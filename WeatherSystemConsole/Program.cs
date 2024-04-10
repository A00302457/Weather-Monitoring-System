// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;
using System.Linq;

using WeatherMonitoringSystem;
var weatherData = WeatherDataSingleton<float>.GetInstance();

Console.WriteLine("Please enter the type of weather data you would like to display: (current, forecast, statics)");
var weatherData1 = Console.ReadLine();
WeatherDataSingleton<float>.GetInstance()._Value1 = 80f;
var weatherDataFactory = WeatherStationFactory.CreateDisplay(weatherData1 ?? "current", new WeatherDataSingleton<float>());
Console.WriteLine(weatherDataFactory.Display());

//var weatherData1 = new WeatherDataSingleton<float>.GetInstance();
var statisticsDisplay = new WeatherDataSingleton<float>();
var forecastDisplay = new WeatherDataSingleton<float>();
var currentConditionsDisplay = new WeatherDataSingleton<float>();












// IDisplayInterface<string>? weatherData = new WeatherDataSingleton();
// Console.WriteLine(weatherData.Display());

// IDisplayInterface<string>? currentConditionsDisplay = new CurrentConditionsDisplay(weatherData);
// Console.WriteLine(currentConditionsDisplay.Display());

// IDisplayInterface<string>? forecastDisplay = new ForecastDisplayObserver();
// Console.WriteLine(forecastDisplay.Display());

// IDisplayInterface<string>? statisticsDisplay = new StatisticsDisplayObserver();
// Console.WriteLine(statisticsDisplay.Display());

// var weatherData = new WeatherDataSingleton<string>(DateTime.Now.ToString());
// var currentConditionsDisplay = new CurrentConditionsDisplay<string>(weatherData);
// var forecastDisplay = new ForecastDisplayObserver<string>(weatherData);
// var statisticsDisplay = new StaticsDisplayObserver<string>(weatherData);

// weatherData.AddObserver(currentConditionsDisplay);
// weatherData.AddObserver(forecastDisplay);
// weatherData.AddObserver(statisticsDisplay);





// currentConditionsDisplay.Display();
// forecastDisplay.Display();
// statisticsDisplay.Display();
//currentConditionsDisplay.value = Console.ReadLine() ?? "";


// var weatherData = WeatherDataSingleton<float>.GetInstance();

/////////////////////////////This line and the two under it should be using a factory to create the observers.

// var statisticsDisplay = new StaticsDisplayObserver<float>();
// var forecastDisplay = new ForecastDisplayObserver(weatherData);
// var currentConditionsDisplay = new CurrentConditionsDisplay(weatherData);
// var weatherStationFactory = new WeatherStationFactory();
// weatherStationFactory.CreateWeatherStation("CurrentConditionsDisplay", weatherData);



// weatherData.AddObserver(statisticsDisplay);
// weatherData.AddObserver(forecastDisplay);
// weatherData.AddObserver(currentConditionsDisplay);

// weatherData._Value1 = 80f;

// Console.WriteLine(statisticsDisplay.Display());
// Console.WriteLine(forecastDisplay.Display());
// Console.WriteLine(currentConditionsDisplay.Display());
