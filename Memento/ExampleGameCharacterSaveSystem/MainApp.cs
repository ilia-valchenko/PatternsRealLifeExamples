using System;

namespace Memento.ExampleGameCharacterSaveSystem
{
    // NOTE: The Memento pattern is a behavioral design pattern that lets you save and restore the previous state of an object
    // without revealing the details of its implementation.

    // Key participants:
    // * Originator: The object whose state we want to save (e.g., a document, a game character).
    // * Memento: An object that holds a snapshot of the Originator’s internal state. It’s usually opaque to other objects.
    // * Caretaker: Manages the mementos (stores, retrieves) but never modifies them. It’s responsible for the history.
    public static class MainApp
    {
        private const int MaxHealth = 100;

        public static void Main()
        {
            // Create character and save system
            GameCharacter hero = new GameCharacter(MaxHealth, 0, 0);
            SaveSystem saveSystem = new SaveSystem();

            // Play for a while
            hero.DisplayStatus();
            hero.Move(5, 10);
            hero.PickupItem("Sword");
            hero.TakeDamage(20);
            hero.DisplayStatus();

            // Save at this point
            saveSystem.SaveGame("checkpoint1", hero.Save());

            // Continue playing
            hero.Move(2, -3);
            hero.PickupItem("Shield");
            hero.TakeDamage(50);
            hero.DisplayStatus();

            // Let's restore to the saved checkpoint
            var savedState = saveSystem.LoadGame("checkpoint1");
            hero.Restore(savedState);

            Console.WriteLine("\n\nTap to continue...");
        }
    }
}
