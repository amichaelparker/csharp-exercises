using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    class Navigation
    {
        private bool keepRunning = true;

        public bool Running
        {
            get { return keepRunning; }
            set { keepRunning = value; }
        }

        public void Options()
        {
            Console.Write("1) Add New Menu Item\n2) Remove Menu Item\n3) Print Current Menu\n4) Print Item Details\n5) Exit\n\nChoice: ");
            string userInput = Console.ReadLine();

            if (userInput == "1")
            {
                Console.WriteLine();
                MenuItem.NewItem();
                Console.Clear();
            }
            else if (userInput == "2")
            {
                Dictionary<int, string> dishes = Menu.ParseItems();

                int selection = Choices(dishes);

                foreach (KeyValuePair<int, string> item in dishes)
                {
                    if (item.Key == selection)
                    {
                        MenuItem.RemoveItem(item.Value);
                        Console.WriteLine("Item Removed");
                    }
                }
                Console.ReadLine();
                Console.Clear();
            }
            else if (userInput == "3")
            {
                Console.Clear();
                Console.WriteLine();
                Menu.PrintMenu();
            }
            else if (userInput == "4")
            {
                Dictionary<int, string> dishes = Menu.ParseItems();

                int selection = Choices(dishes);

                foreach (KeyValuePair<int, string> item in dishes)
                {
                    if (item.Key == selection)
                    {
                        Menu.PrintItem(item.Value.ToString());
                    }
                }
                Console.ReadLine();
                Console.Clear();
            }
            else
            {
                keepRunning = false;
            }
        }

        private int Choices(Dictionary<int, string> dishes)
        {
            string choice = Console.ReadLine();

            if (choice == "0" || choice == "")
            {
                Console.Clear();
                Options();
            }

            int intChoice = Convert.ToInt32(choice);

            while (!dishes.ContainsKey(intChoice))
            {
                Console.WriteLine("Please enter a valid item number.");
                choice = Console.ReadLine();
            }
            return intChoice;
        }
    }
}
