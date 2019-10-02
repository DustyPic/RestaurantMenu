using System;
using System.IO;
using System.Xml.Linq;



namespace RestaurantMenu
{
    class Program
    {
        static void Main(string[] args)
        {



            StreamReader sr = new StreamReader(@"C:\Users\opilane\source\repos\Naidis2\Menüü.xml");
            XElement RestaurantMenu = XElement.Load(sr);


            var food = RestaurantMenu.Elements("food");
            foreach (var Item in food)
            {
                Console.Write(Item.Element("name").Value);
                var Menu = Item.Element("Menu").Elements();
                foreach (var price in Menu)
                {
                    Console.Write(String.Format(
                        " {1} on {0}",
                        price.Value,
                        price.Attribute("type").Value
                    ));
                }
                Console.WriteLine();
                Console.ReadLine();
            }
        }
        public static void Question()
        {
            Console.WriteLine("Would you like to see a Vegan Menu then press (y) if no then press (n)?");
            Choice = Console.ReadLine().ToLower();
            Console.WriteLine();

            if (Choice == "y")
            {
                Console.WriteLine("Vegan Menu will follow");
                var vegan = RestaurantMenu.Elements("vegan");
                foreach (var vegan in Menu)
                {
                    Console.WriteLine();
                }
                return vegan;
            }
            else if (Choice == "n")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("You Chose No");
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine("Wrong Choice");
            }
        }
    }
}