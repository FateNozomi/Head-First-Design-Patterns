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
            WeatherData weatherData1 = new WeatherData(80, 65, 30.4f);
            WeatherData weatherData2 = new WeatherData(82, 70, 29.2f);
            WeatherData weatherData3 = new WeatherData(78, 90, 29.2f);

            CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay(weatherData1);
        }
    }
}
