using System;

namespace Adapter.Example1
{
    public class RandomGenerator
    {
        private readonly Random random = new Random();

        public int GenerateRandomNumber()
        {
            return random.Next();
        }
    }
}