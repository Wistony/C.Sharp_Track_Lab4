using System.Collections.Generic;


namespace Lab4
{
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
            return "(title=\"" + this.Title + "\"; author={" + Author.ToString() + "};" +
                   " publishingHouse=\"" + this.PublishingHouse + "\"; yearOfPublishing=\"" +
                   +this.YearOfPublishing + "\"; value=\"" + this.Value + "\";";
        }
    }

    public class Author
    {
        public string Fullname { get; set; }
        public int YearOfBirth { get; set; }
        public int? YearOfDeath { get; set; }

        public Author()
        {
            
        }

        public Author(string fullname, int yearOfBirth, int? yearOfDeath)
        {
            Fullname = fullname;
            YearOfBirth = yearOfBirth;
            YearOfDeath = yearOfDeath;
        }

        public override string ToString()
        {
            return "fullname=\"" + this.Fullname + "\"; yearOfBirth=\"" +
                   +this.YearOfBirth + "\"; yearOfDeath=\"" + this.YearOfDeath + "\";";
        }
    }
}