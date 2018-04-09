using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                DoWork();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }

        private static void DoWork()
        {
            WeatherProvider weatherProvider = new WeatherProvider();
            CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay();
            ForecastDisplay forecastDisplay = new ForecastDisplay();
            StatisticsDisplay statisticsDisplay = new StatisticsDisplay();
            HeatIndexDisplay heatIndexDisplay = new HeatIndexDisplay();
            currentDisplay.Subscribe(weatherProvider);
            forecastDisplay.Subscribe(weatherProvider);
            statisticsDisplay.Subscribe(weatherProvider);
            heatIndexDisplay.Subscribe(weatherProvider);

            weatherProvider.SetMeasurements(80, 65, 30.4f);
            weatherProvider.SetMeasurements(82, 70, 29.2f);
            weatherProvider.SetMeasurements(78, 90, 29.2f);
            weatherProvider.EndService();
        }
    }
}
