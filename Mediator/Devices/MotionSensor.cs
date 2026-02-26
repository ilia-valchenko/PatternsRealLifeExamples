using System;

namespace Mediator.Devices
{
    public class MotionSensor : BaseDevice
    {
        public void DetectMotion()
        {
            Console.WriteLine("[Motion sensor] Motion detected!");
            _mediator?.Notify(this, "motionDetected");
        }

        public void NoMotion()
        {
            Console.WriteLine("[Motion sensor] No motion.");
            _mediator?.Notify(this, "motionStopped");
        }
    }
}
