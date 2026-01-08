using System;
using Bridge.Example2.Devices.Interfaces;
using Bridge.Example2.Interfaces;

namespace Bridge.Example2
{
    public class RemoteControl : IRemoteControl
    {
        private const int DefaultVolumeStepSize = 10;

        protected readonly IDevice device;

        public RemoteControl(IDevice device)
        {
            this.device = device;
        }

        public void SetExactChannel(int numberOfChannel)
        {
            if (numberOfChannel <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(numberOfChannel));
            }

            this.device.SetChannel(numberOfChannel);
        }

        public void SetNextChannel()
        {
            var nextChannel = this.device.CurrentChannelNumber + 1;
            this.device.SetChannel(nextChannel);
        }

        public void SetPreviousChannel()
        {
            var previousChannel = this.device.CurrentChannelNumber - 1;
            this.device.SetChannel(previousChannel);
        }

        public void TogglePower()
        {
            if (this.device.IsTurnedOn)
            {
                this.device.TurnOff();
            }
            else
            {
                this.device.TurnOn();
            }
        }

        public void VolumeDown()
        {
            var volume = this.device.CurrentVolume - DefaultVolumeStepSize;
            this.device.SetVolume(volume);
        }

        public void VolumeUp()
        {
            var volume = this.device.CurrentVolume + DefaultVolumeStepSize;
            this.device.SetVolume(volume);
        }
    }
}
