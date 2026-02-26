using System;

namespace Mediator.Devices
{
    public class Light : BaseDevice
    {
        public void TurnOn()
        {
            Console.WriteLine("[Light] Turned on.");
            _mediator?.Notify(this, "lightTurnedOn");
        }

        public void TurnOff()
        {
            Console.WriteLine("[Light] Turned off.");
            _mediator?.Notify(this, "lightTurnedOff");
        }
    }
}
