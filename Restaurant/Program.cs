using System;

namespace Restaurant
{
    class Program
    {
        static void Main(string[] args)
        {
            // add test menu items
            TestItems();

            // main program logic
            bool keepRunning = true;

            while (keepRunning)
            {
                Console.Write("1) Add New Menu Item\n2) Print Current Menu\n3) Exit\n\nChoice: ");
                string userInput = Console.ReadLine();

                if (userInput == "1")
                {
                    Console.WriteLine();
                    MenuItem.NewItem();
                    Console.Clear();
                } else if (userInput == "2")
                {
                    Console.Clear();
                    Console.WriteLine();
                    Menu.PrintMenu();
                } else
                {
                    keepRunning = false;
                } 
            }
        }
        
        public static void TestItems()
        {
            MenuItem appetizerItem = new MenuItem();
            appetizerItem.name = "Breadsticks";
            appetizerItem.description = "Bread, now in stick form";
            appetizerItem.category = "Appetizer";
            appetizerItem.price = 19.99M;
            appetizerItem.added = DateTime.Now.AddDays(-8);

            MenuItem firstItem = new MenuItem();
            firstItem.name = "Spaghetti";
            firstItem.description = "Noodles with sauce";
            firstItem.category = "Main Course";
            firstItem.price = 49.99M;
            firstItem.added = DateTime.Now.AddDays(-1);

            MenuItem secondItem = new MenuItem();
            secondItem.name = "Lasagna";
            secondItem.description = "flat noodles with sauce in the middle";
            secondItem.category = "Main Course";
            secondItem.price = 64.99M;
            secondItem.added = DateTime.Now.AddHours(-5);

            MenuItem dessertItem = new MenuItem();
            dessertItem.name = "Tiramisu";
            dessertItem.description = "Light, coffee-flavored cake";
            dessertItem.category = "Dessert";
            dessertItem.price = 149.99M;
            dessertItem.added = DateTime.Now.AddDays(-3);

            Menu.AddItem(appetizerItem);
            Menu.AddItem(firstItem);
            Menu.AddItem(secondItem);
            Menu.AddItem(dessertItem);
        }
    }
}
