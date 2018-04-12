using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteControlTest
{
    public class CeilingFanOffCommand : ICommand
    {
        private CeilingFan _ceilingFan;
        private CeilingFan.Speed _previousSpeed;

        public CeilingFanOffCommand(CeilingFan ceilingFan)
        {
            _ceilingFan = ceilingFan;
        }

        public void Execute()
        {
            _previousSpeed = _ceilingFan.CurrentSpeed;
            _ceilingFan.SetSpeed(CeilingFan.Speed.Off);
        }

        public void Undo()
        {
            _ceilingFan.SetSpeed(_previousSpeed);
        }
    }
}
