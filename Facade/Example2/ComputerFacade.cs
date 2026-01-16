using Facade.Example2.Interfaces;

namespace Facade.Example2
{
    public class ComputerFacade
    {
        private readonly IComputer _computer;

        public ComputerFacade(IComputer computer)
        {
            _computer = computer;
        }

        public void TurnOn()
        {
            _computer.GetElectricShock();
            _computer.MakeSound();
            _computer.ShowLoadingScreen();
        }

        public void TurnOff()
        {
            _computer.CloseEverything();
            _computer.PullCurrent();
            _computer.Sooth();
        }
    }
}
