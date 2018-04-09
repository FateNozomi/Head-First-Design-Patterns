using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStation
{
    public class ForecastDisplay : IObserver<WeatherData>, IDisplayElement
    {
        private WeatherData _currentWeatherData;
        private WeatherData _previousWeatherData;
        private IDisposable _cancellation;

        public void Subscribe(WeatherProvider provider)
        {
            _cancellation = provider.Subscribe(this);
        }

        public void Unsubscribe()
        {
            _cancellation.Dispose();
        }

        public void Display()
        {
            if (_previousWeatherData == null)
            {
                Console.WriteLine(
                    $"Unable to forecast weather " +
                    $"due to lack of previous weather data");
            }
            else
            {
                Console.Write("Forecast: ");
                if (_currentWeatherData.Pressure > _previousWeatherData.Pressure)
                {
                    Console.WriteLine("Improving weather on the way!");
                }
                else if (_currentWeatherData.Pressure < _previousWeatherData.Pressure)
                {
                    Console.WriteLine("Watch out for cooler, rainy weather");
                }
                else
                {
                    Console.WriteLine("More of the same");
                }
            }
        }

        public void OnCompleted()
        {
            Console.WriteLine($"Forecast Display's Weather Provider is shutting down.");
        }

        // Update information
        public void OnNext(WeatherData weatherData)
        {
            _previousWeatherData = _currentWeatherData;
            _currentWeatherData = weatherData;
            Display();
        }

        // No implementation needed: Method is not called by the BaggageHandler class.
        public void OnError(Exception error)
        {
            // No implementation.
        }
    }
}
