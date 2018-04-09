using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStation
{
    public class WeatherProvider : IObservable<WeatherData>
    {
        private List<IObserver<WeatherData>> observers = new List<IObserver<WeatherData>>();
        private List<WeatherData> weatherDatas = new List<WeatherData>();

        public IDisposable Subscribe(IObserver<WeatherData> observer)
        {
            // Check whether observer is already registered. If not, add it
            if (!observers.Contains(observer))
            {
                observers.Add(observer);

                // porvide observer with existing data.
                foreach (var item in weatherDatas)
                {
                    observer.OnNext(item);
                }
            }

            return new Unsubscriber<WeatherData>(observers, observer);
        }

        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            WeatherData weatherData = new WeatherData(temperature, humidity, pressure);
            foreach (IObserver<WeatherData> observer in observers)
            {
                observer.OnNext(weatherData);
            }
        }

        public void EndService()
        {
            foreach (var observer in observers)
            {
                observer.OnCompleted();
            }

            observers.Clear();
        }
    }
}
