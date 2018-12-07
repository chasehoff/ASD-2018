using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_Lecture
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> CarList = new List<string>() { "Silver", "Toyota", "25" };

            //Create a new dictionary
            Dictionary<string, string> CarDictionary = new Dictionary<string, string>();

            //Create values
            CarDictionary.Add("Color", "Silver");
            CarDictionary.Add("MPG", "25");
            CarDictionary.Add("Make", "Toyota");

            //Display values
            Console.WriteLine(CarList[0]);

            //Access a specific key
            Console.WriteLine(CarDictionary["Color"]);

            //Check if key exists in dictionary
            Console.WriteLine(CarDictionary.ContainsKey("Price"));

            CarDictionary.Remove("Make");

            CarDictionary["Pizza"] = "laskdfjaslkdjf";

            //How to loop through a dictionary
            foreach (KeyValuePair<string, string> vp in CarDictionary)
            {
                Console.WriteLine(vp.Value);
            }

            Book book1 = new Book();
            book1.Isbn = 12345;
            book1.Name = "Jaws";

            Book book2 = new Book();
            book2.Isbn = 123456;
            book2.Name = "ET";

            Book book3 = new Book();
            book3.Isbn = 1234567;
            book3.Name = "Suicide";

            Dictionary<int, Book> myBooks = new Dictionary<int, Book>();
            myBooks.Add(book1.Isbn, book1);
            myBooks.Add(book2.Isbn, book2);
            myBooks.Add(book3.Isbn, book3);

            Console.WriteLine(myBooks.Count);
            foreach (KeyValuePair<int, Book> kvp2 in myBooks)
            {
                Console.WriteLine(kvp2.Value.Name);
            }
            Console.ReadKey();

        }
    }
    class Book
    {
        public int Isbn { get; set; }
        public string Name { get; set; }

    }
}
