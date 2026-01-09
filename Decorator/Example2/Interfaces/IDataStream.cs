namespace Decorator.Example2.Interfaces
{
    public interface IDataStream
    {
        byte[] Read();

        void Write(byte[] data);
    }
}
