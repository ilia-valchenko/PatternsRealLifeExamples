using System.Collections.Generic;

namespace Composite.ClassicImplementation
{
    public class Composite : IComponent
    {
        private readonly List<IComponent> children = new List<IComponent>();

        public void Add(IComponent component)
        {
            this.children.Add(component);
        }

        public void Remove(IComponent component)
        {
            this.children.Remove(component);
        }

        public void Execute()
        {
            // Uses recursion for calling the Execute method for all children.
        }
    }
}