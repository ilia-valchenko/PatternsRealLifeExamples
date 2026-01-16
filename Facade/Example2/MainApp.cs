using Facade.Example2.Interfaces;

namespace Facade.Example2
{
    public class MainApp
    {
        // Facade pattern provides a simplified interface to a complex subsystem.
        // A facade is an object that provides a simplified interface to
        // a larger body of code, such as a class library.
        public void Main()
        {
            IComputer computer = new Computer();
            var computerFacade = new ComputerFacade(computer);

            computerFacade.TurnOn();
            computerFacade.TurnOff();
        }
    }
}
