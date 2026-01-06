using Prototype.Interfaces;

namespace Prototype
{
    public abstract class BaseColor : IPrototype<BaseColor>
    {
        protected const int DefaultRed = 0;
        protected const int DefaultGreen = 0;
        protected const int DefaultBlue = 0;

        public abstract string GetColorHexCode();

        public abstract BaseColor Clone();
    }
}