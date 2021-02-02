using System.Collections.Generic;

namespace Strategy
{
    // A strategy pattern is use to perform an operation (or set of operations) in a particular manner.

    // It allows us to change an execution logic on runtime.

    // Using an inheritance is the same as using strategy pattern.
    public abstract class SortStrategy
    {
        public abstract void Sort<T>(List<T> list) where T : class;
    }
}