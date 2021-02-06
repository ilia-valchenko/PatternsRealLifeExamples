using System;

namespace Adapter
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