using Bridge.Example2.Devices;
using Bridge.Example2.Devices.Interfaces;

namespace Bridge.Example2
{
    public class MainApp
    {
        public void Main()
        {
            IDevice tv = new TvDevice();

            // Basic remote control
            RemoteControl basicRemoteForTv = new RemoteControl(tv);

            basicRemoteForTv.TogglePower();
            basicRemoteForTv.SetNextChannel();
            basicRemoteForTv.VolumeUp();
            basicRemoteForTv.VolumeUp();

            // Advanced remote control
            AdvancedRemoteControl advancedRemoteForRadio = new AdvancedRemoteControl(tv);

            advancedRemoteForRadio.SetExactChannel(12);
            advancedRemoteForRadio.VolumeUp();
            advancedRemoteForRadio.Mute();
        }
    }
}
