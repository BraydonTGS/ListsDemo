using System;
using static System.Console;
namespace ListsDemo
{
    public class PartySystem
    {
        List<Character> MyTeam;
        public PartySystem()
        {
            MyTeam = new List<Character>();
        }

        public void Run()
        {
            WriteLine("===> Party Builder <==");
            WriteLine("Let's make a party. ");

            string addResponse;
            do
            {
                Write("\nDo you want to add someone? (Y/N) ");
                addResponse = ReadLine().Trim().ToLower();

                if (addResponse == "y")
                {
                    Write("\nWhat is the character's name? ");
                    string name = ReadLine().Trim();
                    Write("\nWhat is the characters level? ");
                    int level = int.Parse(ReadLine());

                    Character newCharacter = new Character(name, level);
                    MyTeam.Add(newCharacter);
                    WriteLine("\nCharacter Added");

                }

            } while (addResponse == "y");

            foreach (var player in MyTeam)
            {
                player.DisplayCharacter();
            }
            ReadKey();
        }
    }
}

