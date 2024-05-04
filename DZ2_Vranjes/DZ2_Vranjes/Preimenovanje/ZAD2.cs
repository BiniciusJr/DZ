using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ2_Vranjes
{
    internal class ZAD2
    {
        class Product
        {
            public string name { get; private set; } 
            public string price { get; private set; } 
            public bool inStock { get; set; } 

            public Product(string name, string price)
            {
                this.name = name;
                this.price = price;
                this.inStock = false;
            }
        }

        class HandlingOfProducts
        {
            List<Product> products;

            public HandlingOfProducts(List<Product> inventory)
            {
                products = inventory;
            }

            public void ReviveProduct(Product RevivedProduct)
            {
                foreach (Product product in products)
                {
                    if (RevivedProduct == product)
                        product.inStock = true;
                }
            }
            public void RemoveAllProducts()
            {
                products.RemoveAll(product => product.inStock == false);
            }
        }
    }
}
