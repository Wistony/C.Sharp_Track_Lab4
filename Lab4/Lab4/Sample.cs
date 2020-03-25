using System.Collections.Generic;

namespace Lab4
{
    using System.Collections.Generic;

    public static  class Sample
    {
        public static List<Book> Create_KPI_Library()
        {
            var kpiLibrary = new List<Book>
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
                },
                new Book
                {
                    Title = "Tini Zabytuh Predkiv",
                    Author = "Mykhaylo Kotsubinsky",
                    PublishingHouse = "Folio",
                    YearOfPublishing = 2011,
                    Value = 175
                },
                new Book
                {
                    Title = "Eneida",
                    Author = "Mykhaylo Kotsubinsky",
                    PublishingHouse = "Folio",
                    YearOfPublishing = 2007,
                    Value = 130
                },
                new Book
                {
                    Title = "Kateryna",
                    Author = "Taras Shevchenko",
                    PublishingHouse = "Ababagalamaga",
                    YearOfPublishing = 2013,
                    Value = 75
                }
            };
            return kpiLibrary;
        }

        public static List<Book> Create_Kyiv_Library()
        {
            var kyivLibrary = new List<Book>
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
                    Title = "1984",
                    Author = "George Orwell",
                    PublishingHouse = "Ababagalamaga",
                    YearOfPublishing = 2001,
                    Value = 350
                },
                new Book
                {
                    Title = "Hamlet",
                    Author = "William Shakespeare",
                    PublishingHouse = "Simon & Schuster",
                    YearOfPublishing = 199,
                    Value = 400
                },
                new Book
                {
                    Title = "Master i Margarita",
                    Author = "Mykhaylo Bulgakov",
                    PublishingHouse = "Azbuka",
                    YearOfPublishing = 2013,
                    Value = 130
                },
            };
            return kyivLibrary;
        }
        public static List<Author> CreateListOfAuthors()
        {
            var authorList = new List<Author>
            {
                new Author
                {
                    Fullname = "Oleksandr Dovzhenko",
                    YearOfBirth = 1894,
                    YearOfDeath = 1956
                },
                new Author
                {
                    Fullname = "Ivan Nechyi-Levytskiy",
                    YearOfBirth = 1838,
                    YearOfDeath = 1918
                },
                new Author
                {
                    Fullname = "Mykhaylo Kotsubinsky",
                    YearOfBirth = 1864,
                    YearOfDeath = 1913
                },
                new Author
                {
                    Fullname = "Taras Shevchenko",
                    YearOfBirth = 1814,
                    YearOfDeath = 1861
                },
                new Author
                {
                    Fullname = "Lina Kostenko",
                    YearOfBirth = 1930,
                    YearOfDeath = null
                },
                new Author
                {
                    Fullname = "William Shakespeare",
                    YearOfBirth = 1564,
                    YearOfDeath = 1616
                },
                new Author
                {
                    Fullname = "George Orwell",
                    YearOfBirth = 1903,
                    YearOfDeath = 1950
                },
                new Author
                {
                    Fullname = "Mykhaylo Bulgakov",
                    YearOfBirth = 1891,
                    YearOfDeath = 1940
                }
            };
            return authorList;
        }
    }
}