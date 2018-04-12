using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteControlTest
{
    public class CeilingFan
    {
        private string _location;

        public CeilingFan(string location)
        {
            _location = location;
        }

        public enum Speed
        {
            Off,
            Low,
            Medium,
            High
        }

        public Speed CurrentSpeed { get; set; }

        public void SetSpeed(Speed speed)
        {
            CurrentSpeed = speed;
            Console.WriteLine($"{_location} Ceiling Fan was set to {CurrentSpeed}");
        }
    }
}
