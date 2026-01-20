namespace Command.Example1.Interfaces
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }
}
