using System.Collections.Generic;


namespace Lab4
{
    public class Library
    {
        public string LibraryName { get; set; }
        public List<Book> Books { get; set; }

        public Library()
        {
            Books = new List<Book>();
        }

        public void AddBook(Book book)
        {
            Books.Add(book);
        }
    }
    public class Book
    {
        public string Title { get; set; }
        public Author Author { get; set; }
        public string PublishingHouse { get; set; }
        public int YearOfPublishing { get; set; }
        public int Value { get; set; }

        public Book()
        {
            
        }
        public Book(string title, Author author, string publishingHouse, int yearOfPublishing, int value )
        {
            Title = title;
            Author = author;
            PublishingHouse = publishingHouse;
            YearOfPublishing = yearOfPublishing;
            Value = value;
        }

        public override string ToString()
        {
            return "(title=" + this.Title + "; author={" + Author.ToString() + "};" +
                   " publishingHouse=" + this.PublishingHouse + "; yearOfPublishing=" +
                   this.YearOfPublishing + "; value=" + this.Value;
        }
    }

    public class Author
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int YearOfBirth { get; set; }
        public int? YearOfDeath { get; set; }

        public Author()
        {
            
        }

        public Author(string name, string surname, int yearOfBirth, int? yearOfDeath)
        {
            Name = name;
            Surname = Surname;
            YearOfBirth = yearOfBirth;
            YearOfDeath = yearOfDeath;
        }

        public override string ToString()
        {
            return "name=" + this.Name + "; surname=" + this.Surname +
                   "; yearOfBirth=" + this.YearOfBirth + "; yearOfDeath" + this.YearOfDeath;
        }
    }
}