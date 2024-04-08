// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;
using System.Linq;
using WeatherMonitoringSystem;
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


var weatherData = WeatherDataSingleton<float>.GetInstance();

var statisticsDisplay = new StaticsDisplayObserver<float>();
var forecastDisplay = new ForecastDisplayObserver(weatherData);
var currentConditionsDisplay = new CurrentConditionsDisplay(weatherData);



weatherData.AddObserver(statisticsDisplay);
weatherData.AddObserver(forecastDisplay);
weatherData.AddObserver(currentConditionsDisplay);

weatherData._Value1 = 80f;

Console.WriteLine(statisticsDisplay.Display());
Console.WriteLine(forecastDisplay.Display());
Console.WriteLine(currentConditionsDisplay.Display());
