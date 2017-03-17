using System;

namespace Restaurant
{
    class MenuItem
    {
        public string name { get; set; }
        public string description { get; set; }
        public string category { get; set; }
        public decimal price { get; set; }
        public DateTime added { get; set; }

        public static void NewItem()
        {
            MenuItem newItem = new MenuItem();

            Console.Write("Enter the category of the new item (Appetizer, Main Course, Dessert): ");
            string userCategory = Console.ReadLine();
            if (userCategory[0] == Convert.ToChar("M") || userCategory[0] == Convert.ToChar("m"))
            {
                newItem.category = "Main Course";
            } else if (userCategory[0] == Convert.ToChar("D") || userCategory[0] == Convert.ToChar("d"))
            {
                newItem.category = "Dessert";
            } else
            {
                newItem.category = "Appetizer";
            }

            Console.Write("Enter the name of the new item: ");
            newItem.name = Console.ReadLine();

            Console.Write("Enter a description for {0}: ", newItem.name);
            newItem.description = Console.ReadLine();

            Console.Write("Enter the price for {0}: ", newItem.name);
            newItem.price = Convert.ToDecimal(Console.ReadLine());

            newItem.added = DateTime.Now;
            Menu.AddItem(newItem);
        }
    }
}
