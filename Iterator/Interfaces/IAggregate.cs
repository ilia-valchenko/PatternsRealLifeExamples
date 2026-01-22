namespace Iterator.Interfaces
{
    /// <summary>
    /// Interface for creating an Iterator object.
    /// </summary>
    public interface IAggregate<T> where T : class
    {
        int Count { get; }

        void Add(T item);

        void Remove(T item);

        IIterator<T> CreateIterator();
    }
}
