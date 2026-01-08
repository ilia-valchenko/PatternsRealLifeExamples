using Bridge.Example2.Devices.Interfaces;

namespace Bridge.Example2
{
    public class AdvancedRemoteControl : RemoteControl
    {
        public AdvancedRemoteControl(IDevice device) : base(device)
        {
        }

        public void Mute()
        {
            this.device.SetVolume(0);
        }
    }
}
