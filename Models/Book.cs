using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkShopPOO.Models
{
    public class Book : Publication
    {
        public string Autor { get; set; }
        
        public string ISBN { get; set; }

        public string Genre { get; set; }

        public double Price { get; set; }

        public Book(string autor, string isbn, string genre, double price, string title, DateTime publicationYear) : base(title,publicationYear)
        {
            Autor = autor;
            ISBN = isbn;
            Genre = genre;
            Price = price;
        }


        public void ShowInfo()
        {   
            Console.WriteLine($"{Autor,-15} | {Genre,-12} | ${Price,-8} | {ISBN, -13} | {PublicationYear}");
        }
        public void Discount(double discount)
        {
            
            var disCount = Price * (discount / 100);
            var price = disCount;
            Console.WriteLine($"{Autor,-15} | {Genre,-12} | ${price,-8} | {ISBN, -13} | {PublicationYear}");
            
            
        }
    }
}