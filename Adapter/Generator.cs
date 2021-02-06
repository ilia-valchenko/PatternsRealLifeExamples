namespace Adapter
{
    public class Generator : IGenerator
    {
        private int index;

        public Generator()
        {
            this.index = 0;
        }

        public Generator(int startIndex)
        {
            this.index = startIndex;
        }

        public int GenerateNext()
        {
            return index++;
        }
    }
}