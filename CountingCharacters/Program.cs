using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CountingCharacters
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string fileText = System.IO.File.ReadAllText(@"D:\Adam\Google Drive\launchcode\csharp-exercises\CountingCharacters\text.txt");

            SortedDictionary<char, int> characters = new SortedDictionary<char, int>();

            Console.WriteLine("Please enter a string of text to receive a alphabetic character count: ");
            string userInput = Console.ReadLine();

            if (userInput == "")
            {
                userInput = fileText;
                Console.WriteLine("You didn't enter a string, so here's a nice count of a passage from The Raven for you: \n");
            }

            foreach (char letter in userInput.ToLower())
            {
                if (characters.ContainsKey(letter))
                {
                    characters[letter] += 1;
                }
                else if (Char.IsLetter(letter))
                {
                    characters.Add(letter, 1);
                }
            }

            if (userInput == fileText)
            {
                Console.WriteLine("\"{0}\"\n", userInput);
            }
            else
            {
                Console.WriteLine("\nHere is the input text: \n\n\"{0}\"\n", userInput);
            }

            foreach (var pair in characters)
            {
                Console.WriteLine(pair.Key + ": " + pair.Value);
            }
            Console.ReadLine();
        }
    }
}
