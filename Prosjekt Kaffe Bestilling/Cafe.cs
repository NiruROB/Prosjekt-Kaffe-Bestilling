using Prosjekt_Kaffe_Bestilling;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prosjekt_Kaffe_Bestilling
{

    public class Cafe
    {
        private List<Product> menu = new List<Product>();
        private Dictionary<String, int> order = new Dictionary<String, int>();

        public void AddProduct(Product product)
        {
            menu.Add(product);
        }
        public void AddOrder(string productName, int quantity)
        {

            order[productName] = quantity;
        }

        public void RemoveOrder(string productsName)
        {
            order.Remove(productsName);

        }
        public void Menu()
        {
            foreach (var product in menu)
            {
                Console.WriteLine($"{product.Name}: {product.Price} kr");
            }
        }

        public void ValueOrder()
        {
            foreach (var item in order)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
        public void OrderConfirmation()
        {
            double totalCost = 0;
            Console.WriteLine("reciept");
            foreach (var item in order)
            {
                Product product = menu.Find(p => p.Name == item.Key);
                if (product != null)
                {
                    double itemsCost = item.Value * product.Price;
                    totalCost += itemsCost;
                    Console.WriteLine($"{item.Key}: {product.Price} x {item.Value} kr = {itemsCost} kr");

                }
                Console.WriteLine($"Total price: {totalCost}kr");

            }
            Console.WriteLine($"Total price: {totalCost} kr");

        }

    }
}