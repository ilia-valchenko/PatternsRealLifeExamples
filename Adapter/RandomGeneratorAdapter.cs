namespace Adapter
{
    // Note: Wraps incompatible object.
    // Allows the interface of an existing class to be used as another interface.

    // The Adapter pattern is based on composition.
    // It wraps only one class.
    public class RandomGeneratorAdapter : RandomGenerator, IGenerator
    {
        public int GenerateNext()
        {
            return this.GenerateRandomNumber();
        }
    }
}