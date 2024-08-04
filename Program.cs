namespace PetStore1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput = string.Empty;

            Console.WriteLine("Press 1 to add a product");
            Console.WriteLine("Type 'exit' to quit");
            userInput = Console.ReadLine();
            
            while (userInput.ToLower() != "exit")
            {
                if (userInput == "1")
                {
                    DogLeash product = new DogLeash();
                    {
                        Console.WriteLine("Enter Product Name");
                        product.Name = Console.ReadLine();
                        Console.WriteLine(product.Name);

                        Console.WriteLine("What is the descrption");
                        product.Description = Console.ReadLine();

                        Console.WriteLine("What is the material");
                        product.Material = Console.ReadLine();

                        Console.WriteLine($"Product Name = {product.Name}, Description = {product.Description}, Material = {product.Material} ");
                    }

                 
                }

            }

            
        }
    }
}
