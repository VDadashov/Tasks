using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson
{
    internal class Store:Product
    {
        public Product[] products = new Product[0];

        public Product[] AddProduct(Product product)
        {
            Array.Resize(ref products, products.Length+1);

            products[products.Length-1] = product;
            return products;
        }

        public Product[] GetDiscountedProducts() 
        {
            Product[] newProducts = new Product[0];

            for (int i = 0; i < products.Length; i++)
            {
                if (products[i].DiscountPercent > 0)
                {
                    Array.Resize(ref newProducts,newProducts.Length+1);
                    newProducts[newProducts.Length-1] = products[i];
                }
            }
            return newProducts;      
        }

        public Product[] GetProductByPriceRange(int min,int max) 
        {
            Product[] newProducts = new Product[0];

            for (int i = 0; i < products.Length; i++)
            {
                if (products[i].Price > min && products[i].Price < max)
                {
                    Array.Resize(ref newProducts, newProducts.Length + 1);
                    newProducts[newProducts.Length - 1] = products[i];
                }
            }
            return newProducts;
        }
    }
}
