// This namespace organizes our code.
namespace Oops.Abstraction
{
    // This abstract class defines the "buttons" on a generic remote control.
    // It is the simple interface that hides the complexity of the device.
    public abstract class RemoteControl
    {
        public abstract void TurnOn();
        public abstract void TurnOff();
        public abstract void ChangeChannel(int channel);
        public abstract void VolumeUp();
        public abstract void VolumeDown();
        public abstract void ShowMenu();
    }

    // The Television class is the complex device.
    // It provides the actual implementation for the remote's "buttons".
    public class Television : RemoteControl
    {
        // This method implements the TurnOn "button".
        public override void TurnOn()
        {
            // The user doesn't need to know about the internal booting process.
            Console.WriteLine("Television is turning on... (booting up, loading channels)");
        }

        // Implements the TurnOff "button".
        public override void TurnOff()
        {
            Console.WriteLine("Television is turning off... (saving state, powering down)");
        }

        // Implements the ChangeChannel "button".
        public override void ChangeChannel(int channel)
        {
            // The user doesn't need to know about frequency tuning.
            Console.WriteLine($"Channel changed to {channel}. (Tuning to new frequency...)");
        }

        // Implements the VolumeUp "button".
        public override void VolumeUp()
        {
            // The user doesn't need to know about the audio amplifier.
            Console.WriteLine("Volume increased. (Adjusting audio amplifier...)");
        }

        // Implements the VolumeDown "button".
        public override void VolumeDown()
        {
            Console.WriteLine("Volume decreased. (Adjusting audio amplifier...)");
        }

        // Implements the ShowMenu "button".
        public override void ShowMenu()
        {
            // The user doesn't need to know about UI overlays.
            Console.WriteLine("Displaying menu. (Overlaying settings UI on screen...)");
        }
    }
}
