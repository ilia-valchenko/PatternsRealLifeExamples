namespace Composite
{
    public class MainApp
    {
        // Note: The intent of a composite is to "compose" objects into tree structures
        // to represent part-whole hierarchies. This pattern lets clients treat individual
        // objects and compositions uniformly.
        public void Main()
        {
            var firstFile = new File();
            var secondFile = new File();
            var thirdFile = new File();

            var innerDirectory = new Directory();
            innerDirectory.Add(thirdFile);

            var directory = new Directory();
            directory.Add(firstFile);
            directory.Add(secondFile);
            directory.Add(innerDirectory);

            var totalSize = directory.GetSizeInKb();
        }
    }
}