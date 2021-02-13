namespace Composite
{
    public class MainApp
    {
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