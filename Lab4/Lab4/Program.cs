using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab4
{
    using System.ComponentModel.Design;

    public static class Program
    {
        private static void Main()
        {
            var authors = Sample.CreateListOfAuthors();
            var library = Sample.CreateListOfBook();

            var delimiter = new string('=', 180);
 
//------------------------------------------------------------------------------------------------------------------            
          
            Console.WriteLine("1. Sorted list of all books\n");
            var query1 =
                from x in library
                orderby x.Title
                select x.Title;

            foreach (var x in query1)
                Console.WriteLine($"\"{x}\"");
            Console.WriteLine(delimiter); 

//------------------------------------------------------------------------------------------------------------------            

            Console.WriteLine("2. Books that to be published later than 2010 \n");
            var query2 = library
                .Where(n => n.YearOfPublishing > 2010)
                .OrderBy(n => n.YearOfPublishing)
                .Select(n => (n.Title, n.YearOfPublishing));
            
            foreach (var x in query2)
                Console.WriteLine($"{x}");
            Console.WriteLine(delimiter);
            
//------------------------------------------------------------------------------------------------------------------            

            Console.WriteLine("3. Books are grouped by authors \n");
            var query3 =
                from x in library
                group x.Title by x.Author into g
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

            Console.WriteLine("4. The cheapest book \n");
            var query4 = library
                .OrderBy(n => n.Value)
                .ThenBy(n => n.Title)
                .Take(1)
                .Select(n => (n.Author, n.Title, n.Value));

            foreach (var x in query4)
                Console.WriteLine($"{x.ToString()}");
            Console.WriteLine(delimiter);
            
//------------------------------------------------------------------------------------------------------------------            
            
            Console.WriteLine("5. Skip 2 and output 3 next one books \n");
            var query5 = library
                .Skip(2)
                .Take(3);

            foreach (var x in query5)
                Console.WriteLine($"{x}");
            Console.WriteLine(delimiter);
            
//------------------------------------------------------------------------------------------------------------------            
            
            Console.WriteLine("6. Books that begin with a letter \"K\" \n");
            var query6 =
                from x in library
                where x.Title.StartsWith("K")
                select new
                {
                    Publication = x.PublishingHouse,
                    Title = x.Title
                };

            foreach (var x in query6)
                Console.WriteLine($"{x}");
            Console.WriteLine(delimiter);
            
//------------------------------------------------------------------------------------------------------------------            
            
            Console.WriteLine(" 7. Calculate authors age");
            var query7 =
                from x in authors
                let deathYearOrCurrent = x.YearOfDeath ?? DateTime.Now.Year
                let age = deathYearOrCurrent - x.YearOfBirth
                select new
                {
                    FullName = x.Fullname,
                    Age = age
                };
            
            foreach (var x in query7)
                Console.WriteLine($"{x}");
            Console.WriteLine(delimiter);

        }
    }
}