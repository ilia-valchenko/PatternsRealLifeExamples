using System;
using Mediator.Devices;

namespace Mediator
{
    public static class MainApp
    {
        // NOTE: Mediator Pattern — in simple words, it's a way to organize interaction between objects
        // so that they don't know about each other directly and can operate without being tightly coupled.

        /*
         *                          ┌─────────────────┐
                                    │  <<interface>>  │
                                    │ IHomeMediator   │
                                    ├─────────────────┤
                                    │ +Notify()       │
                                    └────────┬────────┘
                                             │ implements
                                             │
                                ┌────────────▼────────────┐
                                │     HomeController      │
                                ├─────────────────────────┤
                                │ - _motionSensor         │
                                │ - _livingRoomLight      │
                                │ - _ac                   │
                                ├─────────────────────────┤
                                │ +RegisterDevices()      │
                                │ +Notify()               │
                                └─────┬───────────────────┘
                                      │ manages
                        ┌─────────────┼─────────────┐
                        │             │             │
                        ▼             ▼             ▼
            ┌───────────────────┐ ┌───────────────┐ ┌───────────────────┐
            │   MotionSensor    │ │     Light     │ │  AirConditioner   │
            ├───────────────────┤ ├───────────────┤ ├───────────────────┤
            │ +DetectMotion()   │ │ +TurnOn()     │ │ +SetNormalMode()  │
            │ +NoMotion()       │ │ +TurnOff()    │ │ +SetEcoMode()     │
            └─────────┬─────────┘ └───────┬───────┘ └─────────┬─────────┘
                      │                   │                   │
                      └───────────────────┼───────────────────┘
                                          │ inherit
                                     ┌────▼────┐
                                     │ Device  │
                                     │ (abstract)│
                                     ├─────────┤
                                     │ # _mediator│
                                     ├─────────┤
                                     │ +SetMediator()│
                                     └─────────┘
                                          ▲
                                          │
                                  ┌───────┴───────┐
                                  │   knows about │
                                  │ IHomeMediator │
                                  └───────────────┘
         */
        public static void Main()
        {
            var motionSensor = new MotionSensor();
            var livingRoomLight = new Light();
            var airConditioner = new AirConditioner();

            var homeController = new HomeController();
            homeController.RegisterDevices(motionSensor, livingRoomLight, airConditioner);

            // Simulate events
            Console.WriteLine("=== Person enters the room ===");
            motionSensor.DetectMotion();

            Console.WriteLine("=== Person stays (no new events) ===");
            // Nothing happens, but we could have a timer for auto-off

            Console.WriteLine("=== Person leaves ===");
            motionSensor.NoMotion();
        }
    }
}
