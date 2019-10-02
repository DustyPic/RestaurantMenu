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
                Console.ReadLine();
            }
        }
    }
}