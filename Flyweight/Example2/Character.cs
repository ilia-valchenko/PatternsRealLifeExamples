using System;
using Flyweight.Example2.Interfaces;

namespace Flyweight.Example2
{
    public class Character : ICharacter
    {
        private readonly char _symbol;
        private readonly string _fontFamily;
        private readonly int _fontSize;
        private readonly ConsoleColor _color;

        /// <summary>
        /// Initializes a new instance of the <see cref="Character"/> class.
        /// </summary>
        public Character(
            char symbol,
            string fontFamily = "Arial",
            int fontSize = 12,
            ConsoleColor color = ConsoleColor.Black)
        {
            _symbol = symbol;
            _fontFamily = fontFamily;
            _fontSize = fontSize;
            _color = color;
        }

        public void Display(int pointSize, int positionX, int positionY)
        {
            // The character rendering logic (simplified for example)
            Console.SetCursorPosition(positionX, positionY);
            Console.ForegroundColor = _color;
            Console.Write(_symbol);
            Console.ResetColor();

            Console.WriteLine(
                $" -> Displaying '{_symbol}' at ({positionX},{positionY}) " +
                $"with point size {pointSize}");
        }
    }
}
