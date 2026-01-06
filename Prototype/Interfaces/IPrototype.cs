namespace Prototype.Interfaces
{
    // Note: It's all about cloning.
    // Create object based on an existing object through cloning.
    public interface IPrototype<T> where T : class
    {
        T Clone();
    }
}