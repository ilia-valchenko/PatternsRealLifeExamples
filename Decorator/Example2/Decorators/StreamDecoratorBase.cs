using Decorator.Example2.Interfaces;

namespace Decorator.Example2.Decorators
{
    // Base decorator
    public abstract class StreamDecoratorBase : IDataStream
    {
        protected readonly IDataStream innerStream;

        /// <summary>
        /// Initializes a new instance of the <see cref="StreamDecoratorBase"/> class.
        /// </summary>
        /// <param name="stream">The instance of the stream we want to wrap.</param>
        protected StreamDecoratorBase(IDataStream stream)
        {
            this.innerStream = stream;
        }

        public virtual byte[] Read() => this.innerStream.Read();

        public virtual void Write(byte[] data)
        {
            this.innerStream.Write(data);
        }
    }
}
