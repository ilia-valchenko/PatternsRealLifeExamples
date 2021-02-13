using System;

namespace Composite
{
    public class File : IComponent
    {
        public string FileName { get; set; }

        public int GetSizeInKb()
        {
            throw new NotImplementedException();
        }
    }
}