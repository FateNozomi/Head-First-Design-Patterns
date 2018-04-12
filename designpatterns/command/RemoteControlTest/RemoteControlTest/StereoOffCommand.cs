using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteControlTest
{
    public class StereoOffCommand : ICommand
    {
        Stereo _stereo;

        public StereoOffCommand(Stereo stereo)
        {
            _stereo = stereo;
        }

        public void Execute()
        {
            _stereo.Off();
        }

        public void Undo()
        {
            _stereo.On();
            _stereo.SetCD();
            _stereo.SetVolume(11);
        }
    }
}
