using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteControlTest
{
    public class CeilingFanLowCommand : ICommand
    {
        private CeilingFan _ceilingFan;
        private CeilingFan.Speed _previousSpeed;

        public CeilingFanLowCommand(CeilingFan ceilingFan)
        {
            _ceilingFan = ceilingFan;
        }

        public void Execute()
        {
            _previousSpeed = _ceilingFan.CurrentSpeed;
            _ceilingFan.SetSpeed(CeilingFan.Speed.Low);
        }

        public void Undo()
        {
            _ceilingFan.SetSpeed(_previousSpeed);
        }
    }
}
