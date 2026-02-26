using System;

namespace Mediator.Devices
{
    public class AirConditioner : BaseDevice
    {
        public void SetNormalMode()
        {
            Console.WriteLine("[AC] Mode: Normal.");
            _mediator?.Notify(this, "acModeChanged", "Normal");
        }

        public void SetEcoMode()
        {
            Console.WriteLine("[AC] Mode: Eco.");
            _mediator?.Notify(this, "acModeChanged", "Eco");
        }
    }
}
