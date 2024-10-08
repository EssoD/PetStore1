﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PetStore1
{
    public class ProductLogic: IProductLogic
    {
        private List<Product> _products;
        private Dictionary<string, DogLeash> _dogleash;
        private Dictionary<string, CatFood> _catfoods;

        public ProductLogic()
        {
            _products = new List<Product>();
            _dogleash = new Dictionary<string, DogLeash>();
            _catfoods = new Dictionary<string, CatFood>();
            addProduct(new Product { Name = "Leather Leash", Price = 26.99M, Quantity = 5 });
            addProduct(new Product { Name = "Bedazzled Leash", Price = 300M, Quantity = 0 });


        }

        public void addProduct(Product product)
        {
            _products.Add(product);

            if (product is DogLeash)
            {
                _dogleash.Add(product.Name, product as DogLeash);

            }
            else if (product is CatFood)
            {
                _catfoods.Add(product.Name, product as CatFood);

            }

        }

        public List<Product> GetAllProducts()
        {
         
               return _products;
        }

        public DogLeash GetDogLeashByName(string name)
        {
            try 
            {
                return _dogleash[name];
            }
            catch
            {
                return null;
            }
            
        }

        public List<Product> GetOnlyInStockProducts()
        {
            List<string> inStockProductNames = new List<string>();

            foreach (var prod in _products)
            {
                if (prod.Quantity > 0)
                {
                    inStockProductNames.Add(prod.Name);
                    Console.WriteLine($" In Stock Items: {prod.Name}");
                }

            }
           
            return _products;
        }

        public List<string> GetOutOfStockProducts()
        {
           return  _products.Where(p => p.Quantity == 0).Select(p => p.Name).ToList();
           
        }
    }
}
