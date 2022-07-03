using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    public class ProductManager//product operasyonu
    {
        public void Add(Product product)
        {
            Console.WriteLine(product.Name + " eklendi.");
        }
        public void Update(Product product)
        {
            Console.WriteLine(product.Name + " güncellendi.");
        }
    }
}
