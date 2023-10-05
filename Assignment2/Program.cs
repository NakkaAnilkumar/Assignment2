using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using static Assignment2.program2;

namespace Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //problem number 1--------------------------------------------------------------------------------

            // Declare and initialize an array
            int[] arr = { 1, 2, 3, 4, 5 };

            // Initialize a variable to store the sum
            int sum = 0;

            // Iterate through the array and add each element to the sum
            foreach (int num in arr)
            {
                sum += num;
            }

            // Display the sum
            Console.WriteLine("Sum of array elements: " + sum);
            Console.ReadLine();

            // problem number 2 & 3================================================================================

            //// Create objects for 5 products
            //Product product1 = new Product
            //{
            //    ProductId = 1,
            //    ProductName = "Laptop",
            //    Price = 899.99M,
            //    UnitOfMeasurement = "Piece",
            //    Qty = 10
            //};

            //Product product2 = new Product
            //{
            //    ProductId = 2,
            //    ProductName = "Smartphone",
            //    Price = 499.99M,
            //    UnitOfMeasurement = "Piece",
            //    Qty = 20
            //};

            //Product product3 = new Product
            //{
            //    ProductId = 3,
            //    ProductName = "Headphones",
            //    Price = 49.99M,
            //    UnitOfMeasurement = "Piece",
            //    Qty = 50
            //};

            //Product product4 = new Product
            //{
            //    ProductId = 4,
            //    ProductName = "Tablet",
            //    Price = 299.99M,
            //    UnitOfMeasurement = "Piece",
            //    Qty = 15
            //};

            //Product product5 = new Product
            //{
            //    ProductId = 5,
            //    ProductName = "Keyboard",
            //    Price = 29.99M,
            //    UnitOfMeasurement = "Piece",
            //    Qty = 30
            //};

            //// You now have objects representing 5 different products

            //// You can access the properties of these objects like this:
            //Console.WriteLine("Product 1: " + product1.ProductName + " - Price: $" + product1.Price);
            //Console.WriteLine("Product 2: " + product2.ProductName + " - Price: $" + product2.Price);
            //Console.WriteLine("Product 3: " + product3.ProductName + " - Price: $" + product3.Price);
            //Console.WriteLine("Product 4: " + product4.ProductName + " - Price: $" + product4.Price);
            //Console.WriteLine("Product 5: " + product5.ProductName + " - Price: $" + product5.Price);

            //// ... and so on for the other products
            //Console.ReadLine();

            //problem number 2 & 4 ==========================================================================================

            //// Create an array of Product objects to store 5 products
            //Product[] products = new Product[5];

            //// Loop to accept data for each product
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("Enter details for Product " + (i + 1) + ":");

            //    // Create a new Product object
            //    products[i] = new Product();

            //    Console.Write("Product ID: ");
            //    products[i].ProductId = int.Parse(Console.ReadLine());

            //    Console.Write("Product Name: ");
            //    products[i].ProductName = Console.ReadLine();

            //    Console.Write("Price: $");
            //    products[i].Price = decimal.Parse(Console.ReadLine());


            //    Console.Write("Unit of Measurement: ");
            //    products[i].UnitOfMeasurement = Console.ReadLine();

            //    Console.Write("Quantity: ");
            //    products[i].Qty = int.Parse(Console.ReadLine());
            //}

            //// Display the data for all products
            //Console.WriteLine("\nProduct Details:");
            //foreach (Product product in products)
            //{
            //    Console.WriteLine("Product ID: " + product.ProductId);
            //    Console.WriteLine("Product Name: " + product.ProductName);
            //    Console.WriteLine("Price: $" + product.Price);
            //    Console.WriteLine("Unit of Measurement: " + product.UnitOfMeasurement);
            //    Console.WriteLine("Quantity: " + product.Qty);
            //    Console.WriteLine();
            //    Console.ReadLine();



                //problem number 5 ================================================================================

                // Create an array of Product objects to store 5 products
                Product[] products = new Product[5];

                // Loop to accept data for each product
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Enter details for Product " + (i + 1) + ":");

                    // Create a new Product object
                    products[i] = new Product();

                    //Console.Write("Product ID: ");
                    // products[i].ProductId = int.Parse(Console.ReadLine());

                    Console.Write("Product Name: ");
                    products[i].ProductName = Console.ReadLine();

                    Console.Write("Price: $");

                    products[i].Price = decimal.Parse(Console.ReadLine());


                    Console.Write("Unit of Measurement: ");
                    products[i].UnitOfMeasurement = Console.ReadLine();

                    Console.Write("Quantity: ");
                    products[i].Qty = int.Parse(Console.ReadLine());
                }

                // Display the data for all products
                Console.WriteLine("\nProduct Details:");
                foreach (Product product in products)
                {
                    Console.WriteLine("Product ID: " + product.ProductId);
                    Console.WriteLine("Product Name: " + product.ProductName);
                    Console.WriteLine("Price: $" + product.Price);
                    Console.WriteLine("Unit of Measurement: " + product.UnitOfMeasurement);
                    Console.WriteLine("Quantity: " + product.Qty);
                    Console.WriteLine();
                    Console.ReadLine();




                }
        }
    }
}
