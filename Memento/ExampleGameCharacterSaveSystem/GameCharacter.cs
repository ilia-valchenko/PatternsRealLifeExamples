using System;
using System.Collections.Generic;

namespace Memento.ExampleGameCharacterSaveSystem
{
    public class GameCharacter
    {
        private int _health;
        private int _x;
        private int _y;
        private List<string> _inventoryList = new List<string>();

        public GameCharacter(int health, int startX, int startY)
        {
            _health = health;
            _x = startX;
            _y = startY;
        }

        public void TakeDamage(int amount)
        {
            _health -= amount;

            if (_health < 0)
            {
                _health = 0;
            }

            Console.WriteLine($"Took {amount} damage. Health now: {_health}.");
        }

        public void Move(int dx, int dy)
        {
            _x += dx;
            _y += dy;

            Console.WriteLine($"Moved to ({_x}, {_y}).");
        }

        public void PickupItem(string item)
        {
            _inventoryList.Add(item);
            Console.WriteLine($"Picked up: {item}.");
        }

        // Creates a memento containing the current state
        public GameCharacterMemento Save()
        {
            Console.WriteLine("Saving game...");
            return new GameCharacterMemento(_health, _x, _y, _inventoryList);
        }

        // Restores state from a memento
        public void Restore(GameCharacterMemento memento)
        {
            _health = memento.Health;
            _x = memento.X;
            _y = memento.Y;
            _inventoryList = new List<string>(memento.InventoryList);

            Console.WriteLine("Game loaded from save.");
            this.DisplayStatus();
        }

        public void DisplayStatus()
        {
            Console.WriteLine($"Status: Health={_health}, Position=({_x}, {_y}), Inventory=[{string.Join(", ", _inventoryList)}]");
        }
    }
}
