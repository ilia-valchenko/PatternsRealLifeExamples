using System;
using System.Collections.Generic;

namespace Flyweight.Example2
{
    public class CharacterFactory
    {
        private readonly Dictionary<char, Character> _characters = new Dictionary<char, Character>();

        public Character GetCharacter(
            char key,
            string fontFamily = "Arial",
            int fontSize = 12,
            ConsoleColor color = ConsoleColor.Black)
        {
            // Characters are keyed by their intrinsic state
            // If character with same symbol and style exists, return it
            if (!_characters.ContainsKey(key))
            {
                _characters[key] = new Character(key, fontFamily, fontSize, color);
            }

            return _characters[key];
        }

        public int GetCharacterCount() => _characters.Count;
    }
}
