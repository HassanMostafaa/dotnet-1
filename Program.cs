using System;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Simple C# application it will take your name and greet you.");
            Console.Write("Please enter your name: ");
            string? name = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(name) || string.IsNullOrEmpty(name))
            {
                Console.Write("Invalid input. Please enter your name: ");
                name = Console.ReadLine();
            }
            Console.WriteLine($"Hey {name}, welcome to the C# world!");

            string? num = Console.ReadLine();
            while (num == null || !int.TryParse(num, out int count) || count <= 0)
            {
                Console.WriteLine("Please enter a valid number greater than 0.");
                num = Console.ReadLine();
            }
            for (int i = 0; i < int.Parse(num); i++)
            {
                Console.WriteLine($"This is message number {i + 1}");
            }

            RealEstate realEstate = new()
            {
                Address = "Elm street 123",
                Price = 250000,
                SquareFootage = 1500
            };
            Console.WriteLine($"The price per square foot for the property at {realEstate.Address} is {realEstate.CalculatePricePerSquareFoot()}.");

            const string dummyFilePath = "dummy.json";
            // read json file
            if (!File.Exists(dummyFilePath))
            {
                Console.WriteLine($"File {dummyFilePath} does not exist.");
                return;
            }
            Dummy? dummyFileContent = JsonConvert.DeserializeObject<Dummy>(File.ReadAllText(dummyFilePath));
            Console.WriteLine($"The content of the file {dummyFilePath} is: {dummyFileContent} with name {dummyFileContent?.Name}");





        }
    }


}