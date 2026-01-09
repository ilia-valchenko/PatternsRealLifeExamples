using System.Text;
using Decorator.Example2.Interfaces;

namespace Decorator.Example2.Decorators
{
    // Decorator 2: Encryption
    public class EncryptedStream : StreamDecoratorBase
    {
        private readonly byte[] _key = Encoding.UTF8.GetBytes("16-byte-key-1234");

        /// <summary>
        /// Initializes a new instance of the see <see cref="EncryptedStream"/> class.
        /// </summary>
        /// <param name="stream">The instance of the stream we want to wrap.</param>
        public EncryptedStream(IDataStream stream) : base(stream)
        {
        }

        public override byte[] Read()
        {
            byte[] encrypted = this.innerStream.Read();
            // Simulate decryption
            byte[] decrypted = new byte[encrypted.Length];

            for (int i = 0; i < encrypted.Length; i++)
            {
                decrypted[i] = (byte)(encrypted[i] ^ _key[i % _key.Length]);
            }

            return decrypted;
        }

        public override void Write(byte[] data)
        {
            // Simulate XOR encryption
            byte[] encrypted = new byte[data.Length];

            for (int i = 0; i < data.Length; i++)
            {
                encrypted[i] = (byte)(data[i] ^ _key[i % _key.Length]);
            }

            this.innerStream.Write(encrypted);
        }
    }
}
