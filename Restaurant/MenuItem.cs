using System;
using System.Collections.Generic;

namespace Restaurant
{
    class MenuItem
    {
        private string _name;
        private string _description;
        private string _category;
        private decimal _price;
        private DateTime _added;
        private DateTime _updated;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public string Category
        {
            get { return _category; }
            set { _category = value; }
        }

        public decimal Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public DateTime Added
        {
            get { return _added; }
            set { _added = value; }
        }

        public DateTime Updated
        {
            get { return _updated; }
            set { _updated = value; }
        }

        public static void NewItem()
        {
            MenuItem newItem = new MenuItem();

            Console.Write("Enter the category of the new item (Appetizer, Main Course, Dessert): ");
            string userCategory = Console.ReadLine();
            if (userCategory[0] == Convert.ToChar("M") || userCategory[0] == Convert.ToChar("m"))
            {
                newItem.Category = "Main Course";
            } else if (userCategory[0] == Convert.ToChar("D") || userCategory[0] == Convert.ToChar("d"))
            {
                newItem.Category = "Dessert";
            } else
            {
                newItem.Category = "Appetizer";
            }

            Console.Write("Enter the name of the new item: ");
            newItem.Name = Console.ReadLine();

            Console.Write("Enter a description for {0}: ", newItem.Name);
            newItem.Description = Console.ReadLine();

            Console.Write("Enter the price for {0}: ", newItem.Name);
            newItem.Price = Convert.ToDecimal(Console.ReadLine());

            newItem.Added = DateTime.Now;
            newItem.Updated = DateTime.Now;
            Menu.AddItem(newItem);
        }

        public static void RemoveItem(string name)
        {
            foreach (KeyValuePair<string, List<MenuItem>> item in Menu.newMenu)
            {
                foreach (MenuItem dish in item.Value)
                {
                    if (dish.Name == name)
                    {
                        item.Value.Remove(dish);
                        break;
                    }
                }
            }
        }
    }
}
