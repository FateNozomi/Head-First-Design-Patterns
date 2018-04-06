namespace WeatherStation
{
    public class WeatherData
    {
        public WeatherData(float temperature, float humidity, float pressure)
        {
            Temperature = temperature;
            Humidity = humidity;
            Pressure = pressure;
        }

        public float Temperature { get; }

        public float Humidity { get; }

        public float Pressure { get; }
    }
}
