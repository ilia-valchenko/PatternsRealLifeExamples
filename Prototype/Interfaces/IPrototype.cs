namespace Prototype.Interfaces
{
    // Note: It's all about cloning.
    public interface IPrototype<T> where T : class
    {
        T Clone();
    }
}