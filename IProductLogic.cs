using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore1
{
    public interface IProductLogic
    {
        void addProduct(Product product);
        List<Product> GetAllProducts();
        DogLeash GetDogLeashByName(string name);
        List<Product> GetOnlyInStockProducts();

        List<string> GetOutOfStockProducts();
        

    }
}
