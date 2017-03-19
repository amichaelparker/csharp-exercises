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
            string newCategory = menuItem.Category.ToString();
            newMenu[newCategory].Add(menuItem);
        }

        public static void PrintMenu()
        {
            foreach (KeyValuePair<string, List<MenuItem>> item in newMenu)
            {
                if (item.Value.Count == 0)
                {
                    Console.WriteLine(item.Key.ToString() +
                        "\n" +
                        new string(Convert.ToChar("_"), item.Key.Length) +
                        "\n\nNo Dishes\n");
                    continue;
                }
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

        public static void PrintItem(string name)
        {
            foreach (KeyValuePair<string, List<MenuItem>> item in newMenu)
            {
                foreach(MenuItem dish in item.Value)
                {
                    if (dish.Name == name)
                    {
                        Write(dish);
                    }
                }
            }
        }

        private static void Write(List<MenuItem> menu)
        {
            foreach (MenuItem list in menu)
            {
                string isNew = "New!";
                if (list.Added < DateTime.Now.AddMonths(-1))
                {
                    isNew = "";
                }
                Console.WriteLine("{0}\n{1}\n{2:C}\n{3} {4}\nUpdated - {5}\n\n",
                    list.Name,
                    list.Description,
                    list.Price,
                    list.Added, 
                    isNew, 
                    list.Updated);
            }
        }

        private static void Write(MenuItem item)
        {
            string isNew = "New!";
            if (item.Added < DateTime.Now.AddMonths(-1))
            {
                isNew = "";
            }
            Console.WriteLine("{0}\n{1}\n{2:C}\n{3} {4}\nUpdated - {5}\n\n",
                item.Name,
                item.Description,
                item.Price,
                item.Added,
                isNew,
                item.Updated);
        }

        public static Dictionary<int, string> ParseItems()
        {
            Dictionary<int, string> dishes = new Dictionary<int, string>();

            int count = 1;
            Console.WriteLine("\n");

            foreach (KeyValuePair<string, List<MenuItem>> item in Menu.newMenu)
            {
                foreach (MenuItem dish in item.Value)
                {
                    dishes.Add(count, dish.Name);
                    Console.WriteLine("{0}: {1}", count, dish.Name);
                    count++;
                }
            }
            Console.WriteLine("0) Quit");
            return dishes;
        }
    }
}
