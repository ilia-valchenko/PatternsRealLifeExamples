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
    public class Cache
    {
        private static readonly Cache instance;
        private Dictionary<string, object> items;

        static Cache()
        {
            instance = new Cache();
        }

        private Cache()
        {
            this.items = new Dictionary<string, object>();
        }

        public static Cache Instance
        {
            get
            {
                return instance;
            }
        }

        public void Add(string key, object value)
        {
            this.items.Add(key, value);
        }

        public void TryAdd(string key, object value)
        {
            if (this.items.ContainsKey(key))
            {
                return;
            }

            this.items.Add(key, value);
        }

        public T Get<T>(string key) where T : class
        {
            return this.items[key] as T;
        }

        public T TryGet<T>(string key) where T : class
        {
            if (!this.items.ContainsKey(key))
            {
                return null;
            }

            return this.items[key] as T;
        }
    }
}