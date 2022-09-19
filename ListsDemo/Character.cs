using System;
using static System.Console;
namespace ListsDemo
{
    public class Character
    {
        private string Name;
        private int Level;

        public Character(string charName, int charLevel)
        {
            Name = charName;

            Level = charLevel;
        }

        public void DisplayCharacter()
        {
            WriteLine($"\n> Name: {Name}");
            WriteLine($"\n> Level: {Level}");

        }
    }
}

