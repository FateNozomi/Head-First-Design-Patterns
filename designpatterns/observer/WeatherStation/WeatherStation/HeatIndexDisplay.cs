using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStation
{
    public class HeatIndexDisplay : IObserver<WeatherData>, IDisplayElement
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
                $"Heat index is " +
                $"{ComputeHeatIndex(_weatherData.Temperature, _weatherData.Humidity)}");
        }

        public void OnCompleted()
        {
            Console.WriteLine($"Heat Index Display's Weather Provider is shutting down.");
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
    }
}
