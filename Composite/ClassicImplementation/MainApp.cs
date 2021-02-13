namespace Composite.ClassicImplementation
{
    public class MainApp
    {
        public void Main()
        {
            var firstLeaf = new Leaf();
            var secondLeaf = new Leaf();
            var anotherLeaf = new AnotherLeaf();

            var innerComposite = new Composite();
            innerComposite.Add(anotherLeaf);

            var foo = new Composite();
            foo.Add(firstLeaf);
            foo.Add(secondLeaf);
            foo.Add(innerComposite);

            foo.Execute();
        }
    }
}