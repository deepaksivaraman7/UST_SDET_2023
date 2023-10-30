using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Product<T>
    {
        private int productId;
        private T name;
        private double price;
        private int quantity;

        public Product(int productId, T name, double price, int quantity)
        {
            ProductId = productId;
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public int ProductId { get => productId; set => productId = value; }
        public T Name { get => name; set => name = value; }
        public double Price { get => price; set => price = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public static List<Product<T>> productList=new();
        public static void AddProduct(Product<T> product)
        {
            productList.Add(product);
            Console.WriteLine("Product added");
        }
        public static void UpdateProduct(int productId,ref T name,double price,int quantity)
        {
            foreach(var item in productList)
            {
                if(item.ProductId == productId)
                {
                    item.Name = name;
                    item.Price = price;
                    item.Quantity = quantity;
                }
            }
            Console.WriteLine("Product updated");
            foreach (var product in productList)
            {
                Console.WriteLine("Product ID: {0}   Product Name: {1}   Price: {2}   Quantity: {3}", product.ProductId, product.Name, product.Price, product.Quantity);
            }
        }
        public static void RemoveProduct(int productId)
        {
            foreach(var item in productList)
            {
                if(item.ProductId == productId)
                {
                    productList.Remove(item);
                    Console.WriteLine("Removed");
                }
            }
            foreach (var product in productList)
            {
                Console.WriteLine("Product ID: {0}   Product Name: {1}   Price: {2}   Quantity: {3}", product.ProductId, product.Name, product.Price, product.Quantity);
            }
        }
        public static void SearchProduct(int productId)
        {
            foreach(var item in productList)
            {
                if(item.productId==productId)
                {
                    Console.WriteLine("Product ID: {0}   Product Name: {1}   Price: {2}   Quantity: {3}", item.ProductId, item.Name, item.Price, item.Quantity);
                }
            }
        }
        //private string? productName;
        //private double price;
        //private int quantity;

        //public Product(string? productName, double price, int quantity)
        //{
        //    ProductName = productName;
        //    Price = price;
        //    Quantity = quantity;
        //}

        //public string? ProductName { get => productName; set => productName = value; }
        //public double Price { get => price; set => price = value; }
        //public int Quantity { get => quantity; set => quantity = value; }

        //public void SetPrice(double newPrice)
        //{
        //    Price= newPrice;
        //}
        //public double ProductValue()
        //{
        //    double totalvalue = Price*Quantity;
        //    return totalvalue;

        //}
        //public void DisplayProducts()
        //{
        //    Console.WriteLine("Product Name: "+ProductName);
        //    Console.WriteLine("Price: "+Price);
        //    Console.WriteLine("Quantity: "+Quantity);
        //}
    }

}
