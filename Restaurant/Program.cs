using System;
using System.Collections.Generic;

namespace Restaurant
{
    class Program
    {
        static void Main(string[] args)
        {
            // add test menu items
            TestItems();

            // main program logic
            Navigation nav = new Navigation();            

            while (nav.Running)
            {
                nav.Options();
            }
        }
        
        public static void TestItems()
        {
            MenuItem appetizerItem = new MenuItem();
            appetizerItem.Name = "Breadsticks";
            appetizerItem.Description = "Bread, now in stick form";
            appetizerItem.Category = "Appetizer";
            appetizerItem.Price = 19.99M;
            appetizerItem.Added = DateTime.Now.AddMonths(-2);
            appetizerItem.Updated = appetizerItem.Added;

            MenuItem firstItem = new MenuItem();
            firstItem.Name = "Spaghetti";
            firstItem.Description = "Noodles with sauce";
            firstItem.Category = "Main Course";
            firstItem.Price = 49.99M;
            firstItem.Added = DateTime.Now;
            firstItem.Updated = firstItem.Added;

            MenuItem secondItem = new MenuItem();
            secondItem.Name = "Lasagna";
            secondItem.Description = "flat noodles with sauce in the middle";
            secondItem.Category = "Main Course";
            secondItem.Price = 64.99M;
            secondItem.Added = DateTime.Now;
            secondItem.Updated = secondItem.Added;

            MenuItem dessertItem = new MenuItem();
            dessertItem.Name = "Tiramisu";
            dessertItem.Description = "Light, coffee-flavored cake";
            dessertItem.Category = "Dessert";
            dessertItem.Price = 149.99M;
            dessertItem.Added = DateTime.Now;
            dessertItem.Updated = dessertItem.Added;

            Menu.AddItem(appetizerItem);
            Menu.AddItem(firstItem);
            Menu.AddItem(secondItem);
            Menu.AddItem(dessertItem);
        }
    }
}
