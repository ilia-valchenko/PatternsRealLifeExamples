namespace Adapter
{
    public class RandomGeneratorAdapter : RandomGenerator, IGenerator
    {
        public int GenerateNext()
        {
            return this.GenerateRandomNumber();
        }
    }
}