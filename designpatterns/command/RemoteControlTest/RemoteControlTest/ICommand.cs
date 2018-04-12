namespace RemoteControlTest
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }
}
