using System;

namespace RemoteControlTest
{
    public class NoCommand : ICommand
    {
        public void Execute() { }

        public void Undo() { }
    }
}