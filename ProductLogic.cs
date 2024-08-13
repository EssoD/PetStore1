using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore1
{
    public class ProductLogic
    {
        private List<Product> _products;
        private Dictionary<string, DogLeash> _dogleash;
        private Dictionary<string, CatFood> _catfoods;

        public ProductLogic()
        {
            _products = new List<Product>();
            _dogleash = new Dictionary<string, DogLeash>();
            _catfoods = new Dictionary<string, CatFood>();

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

    }
}
