using System;
using System.Collections.Generic;
using Ex_Heranca.Entities;

namespace Ex_Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1;  i<= n; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char res = char.Parse(Console.ReadLine());
                if (res == 'c')
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Price: ");
                    double price = double.Parse(Console.ReadLine());

                    list.Add(new Product(name, price));
                } else if(res == 'i')
                {

                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Price: ");
                    double price = double.Parse(Console.ReadLine());
                    Console.Write("Customn free: ");
                    double customsFree = double.Parse(Console.ReadLine());
                    list.Add(new ImportedProduct(name, price, customsFree));

                }
                else
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Price: ");
                    double price = double.Parse(Console.ReadLine());
                    Console.Write("Manufacture date (DD/MM/YYYY):  ");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                    list.Add(new UsedProduct(name, price, manufactureDate));

                }
            }

            Console.WriteLine("PRICE TAGS:");
            foreach(Product obj in list)
            {
                Console.WriteLine(obj.Name + "$" + obj.Price);
            }
        }
    }
}
