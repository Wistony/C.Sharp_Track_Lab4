using System.Collections.Generic;


namespace Lab4
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string PublishingHouse { get; set; }
        public int YearOfPublishing { get; set; }
        public int Value { get; set; }

        public Book()
        {
            
        }
        public Book(string title, string author, string publishingHouse, int yearOfPublishing, int value )
        {
            Title = title;
            Author = author;
            PublishingHouse = publishingHouse;
            YearOfPublishing = yearOfPublishing;
            Value = value;
        }

        public override string ToString()
        {
            return "{ title =\"" + this.Title + "\"; author =\"" + this.Author + "\";" +
                   " publishingHouse =\"" + this.PublishingHouse + "\"; yearOfPublishing =\"" +
                   +this.YearOfPublishing + "\"; value =\"" + this.Value + "\"; }";
        }
    }
}