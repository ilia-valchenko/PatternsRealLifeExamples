using System;

namespace Prototype
{
    // The Prototype allows us to copy an object without going into implementation details.
    // It delegates the work (copying) to the object.
    public class Color : BaseColor
    {
        private int red;
        private int green;
        private int blue;

        public Color()
        {
            this.red = 0;
            this.green = 0;
            this.blue = 0;
        }

        public Color(int red, int green, int blue)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
        }

        public override BaseColor Clone()
        {
            return new Color(this.red, this.green, this.blue);
        }

        public override string GetColorHexCode()
        {
            throw new NotImplementedException();
        }
    }
}