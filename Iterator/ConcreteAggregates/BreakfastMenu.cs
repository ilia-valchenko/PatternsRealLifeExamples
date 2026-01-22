using System;
using Iterator.ConcreteIterators;
using Iterator.Interfaces;

namespace Iterator.ConcreteAggregates
{
    public class BreakfastMenu : IAggregate<MenuItem>
    {
        private MenuItem[] _menuItems = {
            new MenuItem("Pancakes", 8.99m, "Stack of 3 fluffy pancakes with maple syrup.", true),
            new MenuItem("Eggs Benedict", 12.99m, "English muffin with poached eggs and hollandaise.", false),
            new MenuItem("Oatmeal", 6.99m, "Steel-cut oats with berries and honey.", true),
            new MenuItem("Breakfast Burrito", 9.99m, "Scrambled eggs, cheese, and sausage in a tortilla.", false)
        };

        public int Count => _menuItems.Length;

        public IIterator<MenuItem> CreateIterator()
        {
            return new BreakfastMenuIterator(_menuItems);
        }

        #region NotImplemented
        public void Remove(MenuItem item)
        {
            throw new NotImplementedException();
        }

        public void Add(MenuItem item)
        {
            throw new NotImplementedException();
        } 
        #endregion
    }
}
