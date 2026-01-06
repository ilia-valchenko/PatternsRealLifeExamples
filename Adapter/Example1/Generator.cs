namespace Adapter.Example1
{
    public class Generator : IGenerator
    {
        private int index;

        public Generator()
        {
            index = 0;
        }

        public Generator(int startIndex)
        {
            index = startIndex;
        }

        public int GenerateNext()
        {
            return index++;
        }
    }
}