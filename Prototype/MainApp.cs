namespace Prototype
{
    public class MainApp
    {
        public void Main()
        {
            var colorManager = new ColorManager();

            colorManager["red"] = new Color(255, 0, 0);
            colorManager["green"] = new Color(0, 255, 0);
            colorManager["blue"] = new Color(0, 0, 255);

            // User adds personalized colors
            colorManager["pink"] = new Color(255, 192, 203);
            colorManager["cyan"] = new Color(0, 255, 255);
            colorManager["orange"] = new Color(255, 165, 0);

            // User clones selected colors
            Color color1 = colorManager["pink"].Clone() as Color;
            Color color2 = colorManager["cyan"].Clone() as Color;
            Color color3 = colorManager["orange"].Clone() as Color;
        }
    }
}