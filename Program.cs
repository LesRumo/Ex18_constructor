using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex18_constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //an object called book1
            Book book1 = new Book("Harry Potter", "JK Rowling", 400);

            
            Console.WriteLine(book1.title);
            Console.ReadLine();
        }
    }
}
