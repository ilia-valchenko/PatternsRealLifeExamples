using System;

namespace Flyweight.Example2
{
    public class MainApp
    {
        public static void Main()
        {
            var factory = new CharacterFactory();
            var document = new Document(factory);

            // Add the word "HELLO" multiple times
            // Only 5 unique character objects will be created (H, E, L, L, O)
            // Even though we have 15 characters total

            // First "HELLO"
            document.AddCharacter('H', 0, 0);
            document.AddCharacter('E', 1, 0);
            document.AddCharacter('L', 2, 0);
            document.AddCharacter('L', 3, 0);
            document.AddCharacter('O', 4, 0);

            // Second "HELLO" in different positions
            document.AddCharacter('H', 0, 1, 14);
            document.AddCharacter('E', 1, 1, 14);
            document.AddCharacter('L', 2, 1, 14);
            document.AddCharacter('L', 3, 1, 14);
            document.AddCharacter('O', 4, 1, 14);

            // Third "HELLO" with different color
            document.AddCharacter('H', 0, 2, 16, color: ConsoleColor.Red);
            document.AddCharacter('E', 1, 2, 16, color: ConsoleColor.Red);
            document.AddCharacter('L', 2, 2, 16, color: ConsoleColor.Red);
            document.AddCharacter('L', 3, 2, 16, color: ConsoleColor.Red);
            document.AddCharacter('O', 4, 2, 16, color: ConsoleColor.Red);

            document.Render();

            Console.WriteLine("\n\nAdding more characters...");

            // Adding punctuation - these create new flyweights
            document.AddCharacter('!', 5, 0);
            document.AddCharacter('!', 5, 1);
            document.AddCharacter('!', 5, 2);

            document.Render();
        }
    }
}
