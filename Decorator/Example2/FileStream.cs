using Decorator.Example2.Interfaces;

namespace Decorator.Example2
{
    // Concrete component: Basic file stream
    public class FileStream : IDataStream
    {
        private readonly string _filePath;

        /// <summary>
        /// Initializes a new instance of the <see cref="FileStream"/> class.
        /// </summary>
        public FileStream(string filePath)
        {
            _filePath = filePath;
        }

        public byte[] Read() => System.IO.File.ReadAllBytes(_filePath);

        public void Write(byte[] data)
        {
            System.IO.File.WriteAllBytes(_filePath, data);
        }
    }
}
