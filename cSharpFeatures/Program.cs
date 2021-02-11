using cSharpFeatures.Lib;
using System;
using System.Collections.Generic;

namespace cSharpFeatures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CsharpFeatures");
            Book rocky = new Book();
            rocky.Id = null;
            rocky.Title = "Rocky 1";
            rocky.Pages = 123;
            rocky.Sequel = null;

            //nullable type definiëren
            



            string title = rocky?.Title;

            //if (rocky.Sequel.Title == null)
            //    sequelTitle = "<noSequel>";
            //else
            //sequelTitle = rocky.Sequel.Title;
            //null coalescence
            int id = rocky?.Id ?? -1;
            string sequelTitle = rocky?.Sequel?.Title ?? "<noTitle>";

            //string interpolatie
            Console.WriteLine($"Id van boek met titel {title} = {id}");
            Console.WriteLine(sequelTitle+ " " +title);

            //object initializer
            Book lotr1 = new Book();//declare
            //inititalize
            lotr1.Title = "un expected journey";
            lotr1.Id = 1;
            lotr1.Pages = 1235;
            //short single object initialisation
            Book lotr2 = new Book
            { Id = 2, Title = "The two towers", Pages = 1235,
                Sequel = new Book { Id = 3,Title="The return of the king" }
            };
            //multiple/collection classic initialisation
            List<Book> myBooks = new List<Book>();
            myBooks.Add(lotr1);
            myBooks.Add(lotr2);
            //multiple/collection short initialisation
            List<Book> yourBooks = new List<Book>
            {
                new Book{Id=1,Title="Rambo1",Pages=12,Sequel=null },
                null,
                new Book{Id=2,Title="Rambo2",Pages=12,Sequel=null },
                new Book{Id=3,Title="Rambo3",Pages=12,Sequel=null },
                new Book{Id=4,Title="Rambo4",Pages=12,Sequel=null },
            };

            foreach(Book book in yourBooks)
            {
                Console.WriteLine(book?.Title);
            } 
        }
    }
}


