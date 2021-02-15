namespace Flyweight.RefactoringGuruExample
{
    public class Color
    {
        public int Red { get; set; }

        public int Green { get; set; }

        public int Blue { get; set; }

        public Color()
        {
            this.Red = 0;
            this.Green = 0;
            this.Blue = 0;
        }

        public Color(int red, int green, int blue)
        {
            this.Red = red;
            this.Green = green;
            this.Blue = blue;
        }
    }
}