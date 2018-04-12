using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteControlTest
{
    public class GarageDoorDownCommand : ICommand
    {
        GarageDoor _garageDoor;

        public GarageDoorDownCommand(GarageDoor garageDoor)
        {
            _garageDoor = garageDoor;
        }

        public void Execute()
        {
            _garageDoor.Stop();
            _garageDoor.Down();
            _garageDoor.LightOff();
        }

        public void Undo()
        {
            _garageDoor.Stop();
            _garageDoor.Up();
            _garageDoor.LightOn();
        }
    }
}
