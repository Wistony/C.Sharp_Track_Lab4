namespace Lab4
{
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