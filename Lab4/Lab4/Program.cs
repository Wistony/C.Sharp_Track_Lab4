using System;

namespace Lab4
{
    public static class Program
    {
        private static void Main(string[] args)
        {
            var ukraineLibrary = new Library();
            ukraineLibrary.AddBook(new Book
                {
                    Title = "Ukraina v ogni",  
                    Author = new Author
                    {
                        Fullname = "Oleksandr Dovzhenko",
                        YearOfBirth = 1894,
                        YearOfDeath = 1956
                    },
                    PublishingHouse = "Folio",
                    YearOfPublishing = 2010,
                    Value = 150
                },
                new Book
                {
                    Title = "Zacharovana Desna",  
                    Author = new Author
                    {
                        Fullname = "Oleksandr Dovzhenko",
                        YearOfBirth = 1894,
                        YearOfDeath = 1956
                    },
                    PublishingHouse = "Folio",
                    YearOfPublishing = 2011,
                    Value = 150
                },
                new Book
                {
                    Title = "Chorna Rada",  
                    Author = new Author
                    {
                        Fullname = "Panteleimon Kulish",
                        YearOfBirth = 1819,
                        YearOfDeath = 1897
                    },
                    PublishingHouse = "Kristal Book",
                    YearOfPublishing = 2015,
                    Value = 200
                }
            );
            
            
        }
    }
}