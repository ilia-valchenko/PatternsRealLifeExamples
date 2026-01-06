using Prototype.Interfaces;

namespace Prototype
{
    public abstract class BaseColor : IPrototype<BaseColor>
    {
        public abstract string GetColorHexCode();

        public abstract BaseColor Clone();
    }
}