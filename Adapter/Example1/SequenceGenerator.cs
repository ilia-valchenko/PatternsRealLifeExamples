using System.Collections.Generic;

namespace Adapter.Example1
{
    public class SequenceGenerator
    {
        private readonly IGenerator generator;

        public SequenceGenerator(IGenerator generator)
        {
            this.generator = generator;
        }

        public IEnumerable<int> GenerateSequence(int length)
        {
            for (int i = 0; i < length; i++)
            {
                yield return generator.GenerateNext();
            }
        }
    }
}