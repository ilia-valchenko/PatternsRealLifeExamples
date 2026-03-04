using System.Collections.Generic;

namespace Memento.ExampleGameCharacterSaveSystem
{
    public class GameCharacterMemento
    {
        public int Health { get; }
        public int X { get; }
        public int Y { get; }
        public IReadOnlyList<string> InventoryList { get; }

        public GameCharacterMemento(int health, int x, int y, List<string> inventoryList)
        {
            this.Health = health;
            this.X = x;
            this.Y = y;

            // Create a deep copy of the inventory list to prevent external modification
            this.InventoryList = new List<string>(inventoryList).AsReadOnly();
        }
    }
}
