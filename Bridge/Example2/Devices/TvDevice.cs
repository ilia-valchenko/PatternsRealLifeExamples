using System;
using Bridge.Example2.Devices.Interfaces;

namespace Bridge.Example2.Devices
{
    public class TvDevice : IDevice
    {
        private bool _isTurnedOn = false;
        private int _currentVolume;
        private int _currentChannelNumber;

        public bool IsTurnedOn => _isTurnedOn;

        public int CurrentVolume => _currentVolume;

        public int CurrentChannelNumber => _currentChannelNumber;

        public void SetChannel(int channelNumber)
        {
            if (channelNumber <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(channelNumber));
            }

            _currentChannelNumber = channelNumber;
        }

        public void SetVolume(int percent)
        {
            if (percent < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(percent));
            }

            _currentVolume = percent;
        }

        public void TurnOff()
        {
            _isTurnedOn = false;
        }

        public void TurnOn()
        {
            _isTurnedOn = true;
        }
    }
}
