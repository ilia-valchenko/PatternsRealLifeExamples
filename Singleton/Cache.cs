using System.Collections.Generic;

namespace Singleton
{
    // Almost all of the implementations have four common characteristics:
    // 1. Single private parameterless constructor;
    // 2. The class is sealed;
    // 3. The class has a static variable which holdes a reference to an instance;
    // 4. The class has a public static getter.

    // The following techniques are used in opposite to Singleton:
    // 1. Registry
    // 2. Service Locator
    // 3. Dependency Injection

    // The implementation below isn't as lazy, but thread-safe without using locks.
    public sealed class Cache<TValue> where TValue : class
    {
        private static readonly Cache<TValue> _instance;
        private readonly Dictionary<string, TValue> _items;

        static Cache()
        {
            _instance = new Cache<TValue>();
        }

        private Cache()
        {
            _items = new Dictionary<string, TValue>();
        }

        public static Cache<TValue> Instance
        {
            get
            {
                return _instance;
            }
        }

        public void Add(string key, TValue value)
        {
            _items.Add(key, value);
        }

        public void TryAdd(string key, TValue value)
        {
            if (_items.ContainsKey(key))
            {
                return;
            }

            _items.Add(key, value);
        }

        public TValue Get(string key)
        {
            return _items[key];
        }

        public TValue TryGet(string key)
        {
            if (!_items.ContainsKey(key))
            {
                return null;
            }

            return _items[key];
        }
    }
}