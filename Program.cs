using System.ComponentModel.Design;

namespace PetStore1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ProductLogic = new ProductLogic();
            string userInput;


            Console.WriteLine("Press 1 to add a product");
            Console.WriteLine("Press 2 to view a dog leash");
            Console.WriteLine("Press 8 to view all products");
            Console.WriteLine(" press 9 to view all in stock items");
            Console.WriteLine("press 10 to get out of stock items");
            Console.WriteLine("Type 'exit' to quit");
            userInput = Console.ReadLine();


            while (userInput.ToLower() != "exit")
            {
                if (userInput == "1")
                {


                    var product = new DogLeash();
                    {
                        Console.WriteLine("Enter Product Name");
                        product.Name = Console.ReadLine();

                        Console.WriteLine("What is the descrption");
                        product.Description = Console.ReadLine();

                        Console.WriteLine("What is the material");
                        product.Material = Console.ReadLine();
                        
                        Console.WriteLine("What is the price");
                        product.Price = decimal.Parse(Console.ReadLine());


                    }
                    ProductLogic.addProduct(product);
                    Console.WriteLine($"Product Name:  {product.Name}, Description = {product.Description}, Material = {product.Material}, Price = {product.Price} ");

                }

                else if (userInput == "8")
                {
                    var products = ProductLogic.GetAllProducts();

                    foreach (var product in products)
                    {
                        //Console.WriteLine(product);
                        Console.WriteLine(product.Name);
                        Console.WriteLine(product.Description);
                        Console.WriteLine(product.Price);

                    

                    }
                }
                else if (userInput == "2")
                {
                    Console.WriteLine("Enter dog leash name");
                    var leashName = Console.ReadLine();
                    var productRetrieved = ProductLogic.GetDogLeashByName(leashName);
                    if (productRetrieved != null)
                    {
                        Console.WriteLine($"Product Name = {productRetrieved.Name}, Description = {productRetrieved.Description}, Product price = {productRetrieved.Price}");
                        Console.WriteLine($" Discounted Price = {productRetrieved.Price.DiscountThisPrice()}");
                    }
                    else
                    {
                        Console.WriteLine("No product found with that name");
                    }

                }

                else if (userInput == "9")
                {
                    ProductLogic.GetOnlyInStockProducts();

                }

                else if (userInput == "10")
                {
                    var OutofStockItems = ProductLogic.GetOutOfStockProducts();
                    foreach (var item in OutofStockItems)
                    {
                        Console.WriteLine($"Out of stock Items: {item}");
                    }

                    

                }

                    Console.WriteLine("Press 1 to add a product");
                    Console.WriteLine(" 2 to view a dog leash");
                    Console.WriteLine("Press 8 to view all products");
                    Console.WriteLine(" press 9 to view all in stock items");
                    Console.WriteLine("press 10 to get out of stock items");
                    Console.WriteLine("Type 'exit' to quit");
                userInput = Console.ReadLine();

            


            }
        }
    }
} 

