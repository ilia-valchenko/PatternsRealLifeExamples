namespace Iterator.Interfaces
{
    /// <summary>
    /// Interface for accessing and traversing elements.
    /// </summary>
    public interface IIterator<T> where T : class
    {
        bool IsDone { get; }

        T CurrentItem { get; }

        T First();

        bool HasNext();

        T Next();
    }
}
