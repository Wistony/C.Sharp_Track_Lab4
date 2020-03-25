using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab4
{
    public static class Program
    {
        private static void Main()
        {
            var ukraineLibrary = new List<Book>
            {
                new Book
                {
                    Title = "Ukraina v ogni",
                    Author = "Oleksandr Dovzhenko",
                    PublishingHouse = "Folio",
                    YearOfPublishing = 2010,
                    Value = 150
                },
                new Book
                {
                    Title = "Zacharovana Desna",
                    Author = "Oleksandr Dovzhenko",
                    PublishingHouse = "Folio",
                    YearOfPublishing = 2011,
                    Value = 150
                },
                new Book
                {
                    Title = "Kaidasheva Simya",
                    Author = "Ivan Nechyi-Levytskiy",
                    PublishingHouse = "Ranok",
                    YearOfPublishing = 2008,
                    Value = 200
                }
                
            };

            var delimiter = new string('=', 180);
 
//------------------------------------------------------------------------------------------------------------------            
          
            Console.WriteLine("1. Sorted list of all books\n");
            var query1 =
                from x in ukraineLibrary
                orderby x.Title
                select x.Title;

            foreach (var x in query1)
                Console.WriteLine($"\"{x}\"");
            Console.WriteLine(delimiter); 

//------------------------------------------------------------------------------------------------------------------            

            Console.WriteLine("2. Books that to be published later than 2010 \n");
            var query2 = ukraineLibrary
                .Where(n => n.YearOfPublishing > 2010)
                .OrderBy(n => n.YearOfPublishing)
                .Select(n => (n.Title, n.YearOfPublishing));
            
            foreach (var x in query2)
                Console.WriteLine($"{x}");
            Console.WriteLine(delimiter);
            
//------------------------------------------------------------------------------------------------------------------            

            Console.WriteLine("3. Books are grouped by authors \n");
            var query3 =
                from x in ukraineLibrary
                group x.Title by x.Author
                into g
                select new
                {
                    Author = g.Key,
                    Count = g.Count(),
                    Books = from b in g
                            select b
                };

            foreach (var x in query3)
            {
                Console.WriteLine($"{x.Author} - {x.Count}");
                foreach (var b in x.Books)
                {
                    Console.WriteLine($"\t\"{b}\"");
                }
            }
            Console.WriteLine(delimiter);

//------------------------------------------------------------------------------------------------------------------            

            Console.WriteLine("3. The cheapest book \n");
            var query4 = ukraineLibrary
                .OrderBy(n => n.Value)
                .ThenBy(n => n.Title)
                .Take(1)
                .Select(n => (n.Author, n.Title, n.Value));

            foreach (var x in query4)
                Console.WriteLine($"{x}");
                
            
            Console.WriteLine(delimiter);

        }
    }
}