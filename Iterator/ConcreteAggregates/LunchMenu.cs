using System;
using System.Collections.Generic;
using Iterator.Interfaces;

namespace Iterator.ConcreteAggregates
{
    public class LunchMenu : IAggregate<MenuItem>
    {
        private readonly List<MenuItem> _menuItems = new List<MenuItem>
        {
            new MenuItem("Caesar Salad", 10.99m, "Fresh romaine lettuce with Caesar dressing.", true),
            new MenuItem("Club Sandwich", 13.99m, "Turkey, bacon, lettuce, tomato on toasted bread.", false),
            new MenuItem("Veggie Burger", 12.99m, "Plant-based patty with avocado and sprouts.", true),
            new MenuItem("Soup of the Day", 6.99m, "Chef's daily special soup.", true)
        };

        public int Count => _menuItems.Count;

        public void Add(MenuItem item)
        {
            _menuItems.Add(item);
        }

        public IIterator<MenuItem> CreateIterator()
        {
            throw new NotImplementedException();
        }

        public void Remove(MenuItem item)
        {
            _menuItems.Remove(item);
        }
    }
}
