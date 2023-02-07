using System;

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Notebook product1 = new Notebook("Asus", "F415")
            {
                Price= 2100,
            };
            product1.ShowInfo();

            Notebook product2 = new Notebook("MSI", "GF63");
            product2.Price = 2000;
            product2.ShowInfo();

            Notebook product3 = new Notebook("Apple", "Macbook Pro")
            {
                Price = 2900,
            };
            product3.ShowInfo();


            Notebook[] products = new Notebook[] {product1,product2, product3};

            double sum = 0;
            int count = 0;

            for (int i = 0; i < products.Length; i++)
            {
                sum += products[i].Price;
                count++;
            }

            Console.WriteLine($"\nPrice Average = {sum/count}");
        }
    }
}
