using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteControlTest
{
    public class StereoOnWithCDCommand : ICommand
    {
        Stereo _stereo;

        public StereoOnWithCDCommand(Stereo stereo)
        {
            _stereo = stereo; 
        }

        public void Execute()
        {
            _stereo.On();
            _stereo.SetCD();
            _stereo.SetVolume(11);
        }

        public void Undo()
        {
            _stereo.Off();
        }
    }
}
