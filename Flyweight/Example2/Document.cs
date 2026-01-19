using System;
using System.Collections.Generic;
using Flyweight.Example2.Interfaces;

namespace Flyweight.Example2
{
    internal class Document
    {
        private readonly CharacterFactory _characterFactory;
        private readonly List<(ICharacter character, int x, int y, int pointSize)> _content = new List<(ICharacter character, int x, int y, int pointSize)>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Document"/> class.
        /// </summary>
        public Document(CharacterFactory factory)
        {
            _characterFactory = factory;
        }

        public void AddCharacter(
            char symbol,
            int x,
            int y,
            int pointSize = 12,
            string fontFamily = "Arial",
            ConsoleColor color = ConsoleColor.Black)
        {
            var character = _characterFactory.GetCharacter(symbol, fontFamily, 12, color);
            _content.Add((character, x, y, pointSize));
        }

        public void Render()
        {
            Console.WriteLine("\nRendering Document:");
            Console.WriteLine("===================");

            foreach (var (character, x, y, pointSize) in _content)
            {
                character.Display(pointSize, x, y);
            }

            Console.WriteLine($"\nTotal characters in document: {_content.Count}");
            Console.WriteLine($"Unique character objects created: {_characterFactory.GetCharacterCount()}");
            Console.WriteLine($"Memory saved: {_content.Count - _characterFactory.GetCharacterCount()} objects");
        }
    }
}
