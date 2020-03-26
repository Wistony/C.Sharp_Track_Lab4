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
            var kpiLibrary = Sample.Create_KPI_Library();
            var kyivLibrary = Sample.Create_Kyiv_Library();
            var delimiter = new string('=', 180);
 
//------------------------------------------------------------------------------------------------------------------            
          
            Console.WriteLine("1. Sorted list of all books\n");
            var query1 =
                from x in kpiLibrary
                orderby x.Title
                select x.Title;

            foreach (var x in query1)
                Console.WriteLine($"\"{x}\"");
            Console.WriteLine(delimiter); 

//------------------------------------------------------------------------------------------------------------------            

            Console.WriteLine("2. Books that to be published later than 2010 \n");
            var query2 = kpiLibrary
                .Where(n => n.YearOfPublishing > 2010)
                .OrderBy(n => n.YearOfPublishing)
                .Select(n => (n.Title, n.YearOfPublishing));
            
            foreach (var x in query2)
                Console.WriteLine($"{x}");
            Console.WriteLine(delimiter);
            
//------------------------------------------------------------------------------------------------------------------            

            Console.WriteLine("3. Books are grouped by authors \n");
            var query3 =
                from x in kpiLibrary
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
            var query4 = kpiLibrary
                .OrderBy(n => n.Value)
                .ThenBy(n => n.Title)
                .Take(1)
                .Select(n => (n.Author, n.Title, n.Value));

            foreach (var x in query4)
                Console.WriteLine($"{x}");
            Console.WriteLine(delimiter);
            
//------------------------------------------------------------------------------------------------------------------            
            
            Console.WriteLine("5. Skip 2 and output 3 next one books \n");
            var query5 = kpiLibrary
                .Skip(2)
                .Take(3);

            foreach (var x in query5)
                Console.WriteLine($"{x}");
            Console.WriteLine(delimiter);
            
//------------------------------------------------------------------------------------------------------------------            
            
            Console.WriteLine("6. Books that begin with a letter \"K\" \n");
            var query6 =
                from x in kpiLibrary
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
            
            Console.WriteLine("7. Calculate authors age\n");
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
            
//------------------------------------------------------------------------------------------------------------------            
            
            Console.WriteLine("8. All publishing house without repetition");
            var query8 = kpiLibrary
                .Union(kyivLibrary)
                .Select(n => n.PublishingHouse)
                .Distinct();
            
            foreach (var x in query8)
                Console.WriteLine($"{x}");
            Console.WriteLine(delimiter); 
            
//------------------------------------------------------------------------------------------------------------------            

            Console.WriteLine("9. Combine two collections into one and sorted by name and then by value");
            var query9 =
                (from x in kpiLibrary.Union(kyivLibrary)
                    orderby x.Title, x.Value
                    select x).Distinct(new EqualityComparer());

            foreach (var x in query9)
                Console.WriteLine($"{x}");
            Console.WriteLine(delimiter);
            
//------------------------------------------------------------------------------------------------------------------            

            Console.WriteLine(" 10. Combine two collections and join with authors\n");
            var query10 =
                (from x in kpiLibrary.Union(kyivLibrary)
                join a in authors on x.Author  equals a.Fullname
                orderby x.Title
                select new
                {
                    x.Title,
                    x.Author,
                    a.YearOfBirth, 
                    a.YearOfDeath
                }).Distinct();

            foreach (var x in query10)
                Console.WriteLine($"{x}");
            Console.WriteLine(delimiter);
            
//------------------------------------------------------------------------------------------------------------------            
            
            Console.WriteLine(" 11. Total price of books\n");
            var query11 =
                (from x in kyivLibrary
                    select x.Value).Sum(); //.Aggregate((x, y) => x + y);

            Console.WriteLine(query11);
            Console.WriteLine(delimiter);
            
//------------------------------------------------------------------------------------------------------------------            

            Console.WriteLine(" 12. Intersection of two library\n");
            var query12 = kyivLibrary
                .Intersect(kpiLibrary, new EqualityComparer())
                .OrderBy(n => n.Value);
            
            foreach (var x in query12)
                Console.WriteLine($"{x}");
            Console.WriteLine(delimiter);
            
//------------------------------------------------------------------------------------------------------------------            

            Console.WriteLine(" 13. Difference between the two libraries\n");
            var query13 = kpiLibrary
                .Except(kyivLibrary,new EqualityComparer());
            
            foreach (var x in query13)
                Console.WriteLine($"{x}");
            Console.WriteLine(delimiter);
            
            
//------------------------------------------------------------------------------------------------------------------            

            Console.WriteLine(" 14. Publishing house where all books have value more than 150\n");
            var query14 =
                from b in kpiLibrary
                group b by b.PublishingHouse into g
                where g.All(n => n.Value > 150)
                select new
                {
                    Publication = g.Key,
                    Books = 
                        from p in g 
                        select new
                        {
                            p.Title,
                            p.Value
                        }
                };
            
            foreach (var x in query14)
            {
                Console.WriteLine($"{x.Publication}");
                foreach (var b in x.Books)
                {
                    Console.WriteLine($"\t{b}");
                }
            }
            Console.WriteLine(delimiter);
            
//------------------------------------------------------------------------------------------------------------------            
            
            Console.WriteLine(" 15. Misses while the price is less than 350\n");
            var query15 =
                (from x in kyivLibrary
                    select x)
                .SkipWhile(n => n.Value < 350);
            
            foreach (var x in query15)
                Console.WriteLine($"{x}");
            Console.WriteLine(delimiter);
        }
    }
}