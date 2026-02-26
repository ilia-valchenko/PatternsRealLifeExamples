using System;
using Mediator.Devices;
using Mediator.Interfaces;

namespace Mediator
{
    public class HomeController : IMediator
    {
        private MotionSensor _motionSensor;
        private Light _livingRoomLight;
        private AirConditioner _airConditioner;

        public void RegisterDevices(MotionSensor motionSensor, Light livingRoomLight, AirConditioner airConditioner)
        {
            _motionSensor = motionSensor;
            _livingRoomLight = livingRoomLight;
            _airConditioner = airConditioner;

            _motionSensor.SetMediator(this);
            _livingRoomLight.SetMediator(this);
            _airConditioner.SetMediator(this);
        }

        public void Notify(object sender, string eventName, object data = null)
        {
            if (sender is MotionSensor && string.Equals(eventName, "motionDetected", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("[HomeController] Motion event received. Turning on light and AC.");
                _livingRoomLight.TurnOn();
                _airConditioner.SetNormalMode();
            }
            else if (sender is MotionSensor && string.Equals(eventName, "motionStopped", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("[HomeController] Motion stopped. Switching to energy-saving mode in 5 seconds.");
                _livingRoomLight.TurnOff();
                _airConditioner.SetEcoMode();
            }
            else if (sender is Light && string.Equals(eventName, "lightTurnedOn", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("[HomeController] Light turned on.");
            }
            else if (sender is AirConditioner && string.Equals(eventName, "acModeChanged"))
            {
                Console.WriteLine($"[HomeController] AC mode was changed to {data}.");
            }
        }
    }
}
