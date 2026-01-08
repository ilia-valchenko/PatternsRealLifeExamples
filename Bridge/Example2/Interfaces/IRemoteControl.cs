namespace Bridge.Example2.Interfaces
{
    public interface IRemoteControl
    {
        void TogglePower();

        void VolumeUp();

        void VolumeDown();

        void SetNextChannel();

        void SetPreviousChannel();

        void SetExactChannel(int numberOfChannel);
    }
}
