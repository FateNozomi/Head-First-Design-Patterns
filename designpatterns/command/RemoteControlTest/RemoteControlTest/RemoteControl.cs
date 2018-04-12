using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteControlTest
{
    public class RemoteControl
    {
        ICommand[] _onCommands = new ICommand[7];
        ICommand[] _offCommands = new ICommand[7];
        ICommand _undoCommand;

        public RemoteControl()
        {
            ICommand noCommand = new NoCommand();
            for (int i = 0; i < 7; i++)
            {
                _onCommands[i] = noCommand;
                _offCommands[i] = noCommand;
            }

            _undoCommand = noCommand;
        }

        public void SetCommand(int slot, ICommand onCommand, ICommand offCommand)
        {
            _onCommands[slot] = onCommand;
            _offCommands[slot] = offCommand;
        }

        public void OnButtonWasPushed(int slot)
        {
            _onCommands[slot].Execute();
            _undoCommand = _onCommands[slot];
        }

        public void OffButtonWasPushed(int slot)
        {
            _offCommands[slot].Execute();
            _undoCommand = _offCommands[slot];
        }

        public void UndoButtonWasPushed()
        {
            _undoCommand.Undo();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("------ Remote Control ------");
            for (int i = 0; i < _onCommands.Length; i++)
            {
                sb.AppendLine(
                    $"[slot {i}] +" +
                    $"{_onCommands[i].GetType().Name}\t\t" +
                    $"{_offCommands[i].GetType().Name}");
            }

            return sb.ToString();
        }
    }
}
