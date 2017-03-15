using System;
using System.Collections.Generic;

namespace Restaurant
{
    class Menu
    {
        public static Dictionary<string, List<MenuItem>> newMenu = new Dictionary<string, List<MenuItem>>() {
            { "Appetizer", new List<MenuItem>() },
            { "Main Course", new List<MenuItem>() },
            { "Dessert", new List<MenuItem>() }
        };

        public static void AddItem(MenuItem menuItem)
        {
            string newCategory = menuItem.category.ToString();
            newMenu[newCategory].Add(menuItem);
        }

        public static void PrintMenu()
        {
            foreach (KeyValuePair<string, List<MenuItem>> item in newMenu)
            {
                if (item.Key == "Appetizer")
                {
                    Console.WriteLine(item.Key.ToString() + 
                        "\n" + 
                        new string(Convert.ToChar("_"), item.Key.Length) + 
                        "\n\n");
                    Write(item.Value);
                }
                if (item.Key == "Main Course")
                {
                    Console.WriteLine(item.Key.ToString() +
                        "\n" +
                        new string(Convert.ToChar("_"), item.Key.Length) +
                        "\n\n");
                    Write(item.Value);
                }
                if (item.Key == "Dessert")
                {
                    Console.WriteLine(item.Key.ToString() +
                        "\n" +
                        new string(Convert.ToChar("_"), item.Key.Length) +
                        "\n\n");
                    Write(item.Value);
                }
            }
        }

        private static void Write(List<MenuItem> menu)
        {
            foreach (MenuItem list in menu)
            {
                Console.WriteLine("{0}\n{1}\n{2:C}\n{3}\n\n",
                    list.name,
                    list.description,
                    list.price,
                    list.added);
            }
        }
    }
}
