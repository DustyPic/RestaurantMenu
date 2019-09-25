using System;
using System.IO;
using System.Xml.Linq;



namespace RestoraniMenüü
{
    class Program
    {
        static void Main(string[] args)
        {



            StreamReader sr = new StreamReader(@"C:\Users\opilane\source\repos\RestoraniMenüü\RestoraniMenüü\toidumenüü.xml");
            XElement RestaurantMenu = XElement.Load(sr);


            var food = RestaurantMenu.Elements("food");
            foreach (var Item in food)
            {
                Console.Write(Item.Element("name").Value);
                var price = Item.Element("price").Elements();
                foreach (var RestaurantMenu in Item)
                {
                    Console.Write(String.Format(
                        " {1} on {0}",
                        RestaurantMenu.Value,
                        RestaurantMenu.Attribute("type").Value
                    ));
                }
                Console.WriteLine();
            }
        }
    }
}
