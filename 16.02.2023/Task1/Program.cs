using System;
using System.Reflection;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Drink drink1 = new Drink { AlcoholPercent = 10.5 };

            Drink drink2 = new Drink();
            drink2.AlcoholPercent = 5.5;

            Dairy dairy1 = new Dairy();
            Dairy dairy2 = new Dairy();
            
            Store store = new Store();

            store.AddProduct(dairy1);
            store.AddProduct(dairy2);
            store.AddProduct(drink1);
            store.AddProduct(drink2);

            Console.WriteLine(store.AlcoholPercentLimit());

            var arr = store.GetDrinkProducts();

            Console.WriteLine("=====================");

            foreach ( var item in arr )
            {
                Console.WriteLine($"{item.AlcoholPercent} {item.Price}");
            }

            //Console.WriteLine(drink1.No);

            Console.WriteLine("=====================");

            Console.WriteLine(drink1.No);
            Console.WriteLine(drink2.No);
            Console.WriteLine(dairy1.No);
            Console.WriteLine(dairy2.No);

            drink1.AlcoholPercent = 99;

            Console.WriteLine(drink1.AlcoholPercent);

        }
    }
}
