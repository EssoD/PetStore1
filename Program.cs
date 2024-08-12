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
            Console.WriteLine(" 2 to view a dog leash");
            Console.WriteLine("Type 'exit' to quit");
            Console.WriteLine("Press 8 to view all products");
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

                     
                    }
                    ProductLogic.addProduct(product);
                    Console.WriteLine($"Product Name:  {product.Name}, Description = {product.Description}, Material = {product.Material} ");

                }

                else if (userInput == "8")
                {
                    var products = ProductLogic.GetAllProducts();

                    foreach (var product in products)
                    {
                        //Console.WriteLine(product);
                        Console.WriteLine(product.Name);
                        Console.WriteLine(product.Description);
                        //Console.WriteLine(product.Material);

                    }
                }
                else if (userInput == "2")
                {
                    Console.WriteLine("Enter dog leash name");
                    var leashName = Console.ReadLine();
                   var productRetrieved = ProductLogic.GetDogLeashByName(leashName);
                    Console.WriteLine($"Product Name:  {productRetrieved.Name}, Description = {productRetrieved.Description}");
                }

                Console.WriteLine("Press 1 to add a product");
                Console.WriteLine(" 2 to view a dog leash");
                Console.WriteLine("Type 'exit' to quit");
                Console.WriteLine("Press 8 to view all products");
                userInput = Console.ReadLine();

            }


        }
    }
    }
   

