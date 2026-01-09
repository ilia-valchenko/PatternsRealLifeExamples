using System;
using System.Text;
using Decorator.Example2.Decorators;
using Decorator.Example2.Interfaces;

namespace Decorator.Example2
{
    public class MainApp
    {
        public void Main()
        {
            // Create simple file stream
            IDataStream stream = new FileStream("data.bin");

            // Wrap with encryption
            IDataStream streamWithEncryption = new EncryptedStream(stream);

            // Wrap with compression (on top of encryption)
            IDataStream streamWithEncryptionAndCompression = new CompressedStream(streamWithEncryption);

            // Act: Write data - gets compressed, then encrypted, then written to file
            byte[] data = Encoding.UTF8.GetBytes("Hello, Decorator Pattern!");
            streamWithEncryptionAndCompression.Write(data);

            // Read data - reads from file, decryptes, then decompresses
            byte[] result = streamWithEncryptionAndCompression.Read();
            Console.WriteLine($"Final result: {Encoding.UTF8.GetString(result)}");
        }
    }
}
