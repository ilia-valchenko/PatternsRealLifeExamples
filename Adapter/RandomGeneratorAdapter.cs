namespace Adapter
{
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