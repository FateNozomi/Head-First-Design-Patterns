using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteControlTest
{
    public class GarageDoorUpCommand : ICommand
    {
        private GarageDoor _garageDoor;

        public GarageDoorUpCommand(GarageDoor garageDoor)
        {
            _garageDoor = garageDoor;
        }

        public void Execute()
        {
            _garageDoor.Stop();
            _garageDoor.Up();
            _garageDoor.LightOn();
        }

        public void Undo()
        {
            _garageDoor.Stop();
            _garageDoor.Down();
            _garageDoor.LightOff();
        }
    }
}
