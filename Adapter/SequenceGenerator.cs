using System.Collections.Generic;

namespace Adapter
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
                yield return this.generator.GenerateNext();
            }
        }
    }
}