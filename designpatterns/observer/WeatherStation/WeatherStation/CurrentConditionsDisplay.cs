using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStation
{
    public class CurrentConditionsDisplay : IDisplayElement
    {
        private WeatherData _weatherData;
        private float _temperature;
        private float _humidity;
        private float _heatIndex;

        public CurrentConditionsDisplay(WeatherData weatherData)
        {
            _weatherData = weatherData;
        }

        public void Update(float temperature, float humidity, float pressure)
        {
            _temperature = temperature;
            _humidity = humidity;
            _heatIndex = ComputeHeatIndex(_temperature, _humidity);
            Display();
        }

        private float ComputeHeatIndex(float t, float rh)
        {
            float index =
                (float)
                (
                (16.923 + (0.185212 * t)) +
                (5.37941 * rh) -
                (0.100254 * t * rh) +
                (0.00941695 * (t * t)) +
                (0.00728898 * (rh * rh)) +
                (0.000345372 * (t * t * rh)) -
                (0.000814971 * (t * rh * rh)) +
                (0.0000102102 * (t * t * rh * rh)) -
                (0.000038646 * (t * t * t)) +
                (0.0000291583 * (rh * rh * rh)) +
                (0.00000142721 * (t * t * t * rh)) +
                (0.000000197483 * (t * rh * rh * rh)) -
                (0.0000000218429 * (t * t * t * rh * rh)) +
                (0.000000000843296 * (t * t * rh * rh * rh)) -
                (0.0000000000481975 * (t * t * t * rh * rh * rh)));
            return index;
        }

        public void Display()
        {
            Console.WriteLine(
                $"Current conditions: " +
                $"{_temperature}F degrees and " +
                $"{_humidity}% humidity" +
                $"\nHeat index is {_heatIndex}");
        }

    }
}
