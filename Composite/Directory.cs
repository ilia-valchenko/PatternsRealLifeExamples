using System.Collections.Generic;

namespace Composite
{
    public class Directory : IComponent
    {
        private readonly List<IComponent> children = new List<IComponent>();

        public string DirectoryName { get; set; }

        public void Add(IComponent component)
        {
            this.children.Add(component);
        }

        public void Remove(IComponent component)
        {
            this.children.Remove(component);
        }

        public int GetSizeInKb()
        {
            int totalSize = 0;

            foreach (var item in this.children)
            {
                totalSize += item.GetSizeInKb();
            }

            return totalSize;
        }
    }
}