using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alice
{
    class Program
    {
        static void Main(string[] args)
        {
            string search;
            string wonderland = @"Alice was beginning to get very tired of sitting 
                                  by her sister on the bank, and of having nothing 
                                  to do: once or twice she had peeped into the book 
                                  her sister was reading, but it had no pictures or 
                                  conversations in it, 'and what is the use of a book,' 
                                  thought Alice 'without pictures or conversation?'".ToLower();

            Console.WriteLine("Enter a word to search for in the Alice text:");
            search = Console.ReadLine().ToLower();

            if (wonderland.Contains(search))
            {
                Console.WriteLine("True");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("False");
                Console.ReadLine();
            }
        }
    }
}
