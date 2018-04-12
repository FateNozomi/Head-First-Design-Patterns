using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteControlTest
{
    public class GarageDoor
    {
        private string _location;

        public GarageDoor(string location)
        {
            _location = location;
        }

        public void Up()
        {
            Console.WriteLine($"{_location} garage door is opened.");
        }

        public void Down()
        {
            Console.WriteLine($"{_location} garage door is closed.");
        }

        public void Stop()
        {
            Console.WriteLine($"{_location} garage door is stopped");
        }

        public void LightOn()
        {
            Console.WriteLine($"{_location} garage light is on");
        }

        public void LightOff()
        {
            Console.WriteLine($"{_location} garage light is off");
        }
    }
}
