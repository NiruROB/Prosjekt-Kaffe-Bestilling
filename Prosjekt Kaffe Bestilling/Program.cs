using Prosjekt_Kaffe_Bestilling;
using System;
using System.Collections.Generic;

namespace CafeOrderingSystem
{

    class Program
    {
        static void Main(string[] args)
        {

            Cafe cafe = new Cafe();

            
            cafe.AddProduct(new Product("Kaffe", 25));
            cafe.AddProduct(new Product("Croissant", 40));
            cafe.AddProduct(new Product("Tea", 30));
            cafe.AddProduct(new Product("Bagel", 35));
            cafe.AddProduct(new Product("Donut", 12));
            cafe.AddProduct(new Product("Biscuit", 5)); 

            Console.WriteLine("Welcome to the Cafe!!!!");
            Console.WriteLine("Menu: ");
            cafe.Menu();

            cafe.AddOrder("Kaffe", 2);
            cafe.AddOrder("Bagel", 3);
            cafe.AddOrder("Croissant", 2);
            cafe.AddOrder("Biscuit", 4); 

            Console.WriteLine("\nYour Order: ");
            cafe.ValueOrder();


            cafe.RemoveOrder("Croissant");

            Console.WriteLine("\nNew order list:");
            cafe.ValueOrder();

            // confirmation

            cafe.OrderConfirmation();

        }
    }
}
   

   