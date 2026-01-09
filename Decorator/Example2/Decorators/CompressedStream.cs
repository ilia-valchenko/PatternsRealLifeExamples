using System;
using Decorator.Example2.Interfaces;

namespace Decorator.Example2.Decorators
{
    // Decorator 1: Compression
    public class CompressedStream : StreamDecoratorBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CompressedStream"/> class.
        /// </summary>
        /// <param name="stream">The instance of the stream we want to wrap.</param>
        public CompressedStream(IDataStream stream) : base(stream)
        {
        }

        public override byte[] Read()
        {
            byte[] compressed = this.innerStream.Read();
            // Simulate decompression - return original data
            byte[] decompressed = new byte[compressed.Length * 2];
            Array.Copy(compressed, decompressed, compressed.Length);
            return decompressed;
        }

        public override void Write(byte[] data)
        {
            // Simulate compression - write half the size
            byte[] compressed = new byte[data.Length / 2];
            Array.Copy(data, compressed, compressed.Length);
            this.innerStream.Write(compressed);
        }
    }
}
