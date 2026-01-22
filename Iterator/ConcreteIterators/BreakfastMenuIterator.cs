using System;
using System.Collections.Generic;
using System.Linq;
using Iterator.Interfaces;

namespace Iterator.ConcreteIterators
{
    public class BreakfastMenuIterator : IIterator<MenuItem>
    {
        private readonly IEnumerable<MenuItem> _items;

        private int _currentPosition = 0;

        /// <summary>
        /// Initializes a new instance or the <see cref="BreakfastMenuIterator"/> class.
        /// </summary>
        public BreakfastMenuIterator(IEnumerable<MenuItem> items)
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
            if (_items.Count() == 0)
            {
                throw new InvalidOperationException("Can't get the first item. No elements.");
            }

            var array = _items.ToArray();
            return array[0];
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
