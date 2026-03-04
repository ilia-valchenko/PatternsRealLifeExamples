using System;
using System.Collections.Generic;

namespace Memento.ExampleGameCharacterSaveSystem
{
    // Caretaker - manages save slots
    public class SaveSystem
    {
        private readonly Dictionary<string, GameCharacterMemento> _saves = new Dictionary<string, GameCharacterMemento>();

        public void SaveGame(string slotName, GameCharacterMemento memento)
        {
            _saves[slotName] = memento;
            Console.WriteLine($"Game saved to slot '{slotName}'.");
        }

        public GameCharacterMemento LoadGame(string slotName)
        {
            if (_saves.TryGetValue(slotName, out var memento))
            {
                Console.WriteLine($"Loading game from slot '{slotName}'...");
                return memento;
            }

            throw new Exception($"No save found in slot '{slotName}'.");
        }
    }
}
