using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace Task1
{
    internal class Store
    {
        public Product[] products = new Product[0];



        public int DairyProductCountLimit()
        {
            int count = 0;

            foreach (var item in products)
            {
                if (item is Dairy)
                {
                    count++;
                }
            }
            return count;
        }

        public double AlcoholPercentLimit()
        {
            Drink[] drinks = new Drink[0];

            foreach (Product item in products)
            {
                if (item is Drink)
                {
                    Drink drink = (Drink)item;

                    Array.Resize(ref drinks, drinks.Length+1);
                    drinks[drinks.Length - 1] = drink;
                }
            }

            double maxAlcoholPercent = 0;

            foreach (Drink item in drinks)
            {

                if (item.AlcoholPercent > maxAlcoholPercent)
                {
                    maxAlcoholPercent = item.AlcoholPercent;
                }
            }

            return maxAlcoholPercent;
        }

        public void AddProduct(Product product)
        {
            Array.Resize(ref products,products.Length+1);
            products[products.Length - 1] = product;
        }

        public bool HasProductByNo(int no)
        {
            foreach (var item in products)
            {
                if (item.No == no)
                {
                    return true;
                }
            }
            return false;
        }

        public Drink[] GetDrinkProducts()
        {
            Drink[] drinks= new Drink[0];

            foreach (var item in products)
            {
                if (item is Drink)
                {
                    Drink drink = (Drink)item;

                    Array.Resize(ref drinks, drinks.Length+1);
                    drinks[drinks.Length - 1] = drink;
                }
            }

            return drinks;
        }

        public Dairy[] GetDairyProducts()
        {
            Dairy[] dairys = new Dairy[0];

            foreach (var item in products)
            {
                if (item is Dairy)
                {
                    Dairy dairy = (Dairy)item;

                    Array.Resize(ref dairys, dairys.Length + 1);
                    dairys[dairys.Length - 1] = dairy;
                }
            }

            return dairys;
        }




    }
}
