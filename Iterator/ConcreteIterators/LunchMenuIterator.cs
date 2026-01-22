using System;
using System.Collections.Generic;
using System.Linq;
using Iterator.Interfaces;

namespace Iterator.ConcreteIterators
{
    public class LunchMenuIterator : IIterator<MenuItem>
    {
        private List<MenuItem> _items;

        private int _currentPosition = 0;

        /// <summary>
        /// Initializes a new instance of the <see cref="LunchMenuIterator"/> class.
        /// </summary>
        public LunchMenuIterator(List<MenuItem> items)
        {
            if (items == null)
            {
                throw new ArgumentNullException(nameof(items));
            }

            _items = items;
        }

        public bool IsDone => throw new NotImplementedException();

        public MenuItem CurrentItem {
            get {
                var array = _items.ToArray();
                return array[_currentPosition];
            }
        }

        public MenuItem First()
        {
            return _items.First();
        }

        public bool HasNext()
        {
            var array = _items.ToArray();
            return array.Length > _currentPosition && array[_currentPosition + 1] != null;
        }

        public MenuItem Next()
        {
            if (!this.HasNext())
            {
                throw new InvalidOperationException("No more items.");
            }

            var array = _items.ToArray();
            return array[_currentPosition++];
        }
    }
}
