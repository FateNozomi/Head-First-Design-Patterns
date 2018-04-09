using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStation
{
    public class StatisticsDisplay : IObserver<WeatherData>, IDisplayElement
    {
        private float maxTemperature = 0.0f;
        private float minTemperature = float.MaxValue;
        private float temperatureSum = 0.0f;
        private int numberOfReadings = 0;
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
                $"AvgMaxMin temperature = " +
                $"{temperatureSum / numberOfReadings}" +
                $"/{maxTemperature}" +
                $"/{minTemperature}");
        }

        public void OnCompleted()
        {
            maxTemperature = 0;
            minTemperature = 0;
            temperatureSum = 0;
            numberOfReadings = 0;
            Console.WriteLine($"Statistics Display's Weather Provider is shutting down.");
        }

        // Update information
        public void OnNext(WeatherData weatherData)
        {
            float temperature = weatherData.Temperature;
            temperatureSum += temperature;
            numberOfReadings++;

            if (temperature > maxTemperature)
            {
                maxTemperature = temperature;
            }

            if (temperature < minTemperature)
            {
                minTemperature = temperature;
            }

            Display();
        }

        // No implementation needed: Method is not called by the BaggageHandler class.
        public void OnError(Exception error)
        {
            // No implementation.
        }
    }
}
