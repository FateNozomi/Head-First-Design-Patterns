using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteControlTest
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                DoWork();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }

        private static void DoWork()
        {
            RemoteControl remote = new RemoteControl();

            Light light = new Light();
            GarageDoor garageDoor = new GarageDoor("Bedroom");
            Stereo stereo = new Stereo("Living Room");
            CeilingFan ceilingFan = new CeilingFan("Dining Room");


            LightOnCommand lightOn = new LightOnCommand(light);
            LightOffCommand lightOff = new LightOffCommand(light);
            GarageDoorUpCommand garageDoorUp = new GarageDoorUpCommand(garageDoor);
            GarageDoorDownCommand garageDoorDown = new GarageDoorDownCommand(garageDoor);
            StereoOnWithCDCommand stereoOnWithCD = new StereoOnWithCDCommand(stereo);
            StereoOffCommand stereoOff = new StereoOffCommand(stereo);
            CeilingFanOffCommand ceilingFanOff = new CeilingFanOffCommand(ceilingFan);
            CeilingFanLowCommand ceilingFanLow = new CeilingFanLowCommand(ceilingFan);
            CeilingFanHighCommand ceilingFanHigh = new CeilingFanHighCommand(ceilingFan);

            ICommand[] partyOn = { lightOn, stereoOnWithCD, garageDoorUp, ceilingFanHigh };
            ICommand[] partyOff = { lightOff, stereoOff, garageDoorDown, ceilingFanOff };
            MacroCommand partyOnMacro = new MacroCommand(partyOn);
            MacroCommand partyOffMacro = new MacroCommand(partyOff);

            remote.SetCommand(0, lightOn, lightOff);
            remote.SetCommand(1, garageDoorUp, garageDoorDown);
            remote.SetCommand(2, stereoOnWithCD, stereoOff);
            remote.SetCommand(3, ceilingFanLow, ceilingFanOff);
            remote.SetCommand(4, ceilingFanHigh, ceilingFanOff);
            remote.SetCommand(5, partyOnMacro, partyOffMacro);

            Console.WriteLine(remote);

            Console.WriteLine("Light");
            remote.OnButtonWasPushed(0);
            remote.OffButtonWasPushed(0);
            Console.WriteLine("Undo Button Pressed");
            remote.UndoButtonWasPushed();
            Console.WriteLine();

            Console.WriteLine("Garage Door");
            remote.OnButtonWasPushed(1);
            remote.OffButtonWasPushed(1);
            Console.WriteLine("Undo Button Pressed");
            remote.UndoButtonWasPushed();
            Console.WriteLine();

            Console.WriteLine("Stereo");
            remote.OnButtonWasPushed(2);
            remote.OffButtonWasPushed(2);
            Console.WriteLine("Undo Button Pressed");
            remote.UndoButtonWasPushed();
            Console.WriteLine();

            Console.WriteLine("Ceiling Fan");
            remote.OnButtonWasPushed(3);
            remote.OnButtonWasPushed(4);
            Console.WriteLine("Undo Button Pressed");
            remote.UndoButtonWasPushed();
            remote.OffButtonWasPushed(3);
            remote.OffButtonWasPushed(4);
        }
    }
}
