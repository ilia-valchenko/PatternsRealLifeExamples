namespace Bridge.Example2.Devices.Interfaces
{
    public interface IDevice
    {
        bool IsTurnedOn { get; }

        int CurrentVolume { get; }

        int CurrentChannelNumber { get; }

        void TurnOn();

        void TurnOff();

        void SetVolume(int percent);

        void SetChannel(int channelNumber);
    }
}
