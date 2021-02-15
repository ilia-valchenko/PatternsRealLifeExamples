namespace Flyweight.RefactoringGuruExample
{
    public class Coordinates
    {
        public int X { get; set; }

        public int Y { get; set; }

        public int Z { get; set; }

        public Coordinates()
        {
            this.X = 0;
            this.Y = 0;
            this.Z = 0;
        }

        public Coordinates(int x, int y, int z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }
    }
}