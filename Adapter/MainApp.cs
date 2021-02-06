namespace Adapter
{
    public class MainApp
    {
        public void Main()
        {
            var adapter = new RandomGeneratorAdapter();
            var sequenceGenerator = new SequenceGenerator(adapter);
            var sequence = sequenceGenerator.GenerateSequence(1000);
        }
    }
}