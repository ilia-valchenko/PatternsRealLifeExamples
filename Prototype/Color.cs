using System;

namespace Prototype
{
    // The Prototype allows us to copy an object without going into implementation details.
    // It delegates the work (copying) to the object.
    public class Color : BaseColor
    {
        private readonly int _red;
        private readonly int _green;
        private readonly int _blue;

        public Color()
        {
            _red = DefaultRed;
            _green = DefaultGreen;
            _blue = DefaultBlue;
        }

        public Color(int red, int green, int blue)
        {
            _red = red;
            _green = green;
            _blue = blue;
        }

        public override BaseColor Clone()
        {
            return new Color(_red, _green, _blue);
        }

        public override string GetColorHexCode()
        {
            throw new NotImplementedException();
        }
    }
}