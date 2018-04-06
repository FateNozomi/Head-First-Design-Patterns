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
    }
}
