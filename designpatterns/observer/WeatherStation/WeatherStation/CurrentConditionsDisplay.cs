using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStation
{
    public class CurrentConditionsDisplay : IObserver<WeatherData>, IDisplayElement
    {
        private WeatherData _weatherData;
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
            Console.WriteLine(
                $"Current conditions: " +
                $"{_weatherData.Temperature}F degrees and " +
                $"{_weatherData.Humidity}% humidity");
        }

        public void OnCompleted()
        {
            Console.WriteLine($"Current Condition Display's Weather Provider is shutting down.");
        }

        // Update information
        public void OnNext(WeatherData weatherData)
        {
            _weatherData = weatherData;
            Display();
        }

        // No implementation needed: Method is not called by the BaggageHandler class.
        public void OnError(Exception error)
        {
            // No implementation.
        }
    }
}
