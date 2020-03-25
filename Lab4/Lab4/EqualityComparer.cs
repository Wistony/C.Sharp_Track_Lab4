using System;
using System.Collections.Generic;

namespace Lab4
{
    public class EqualityComparer : IEqualityComparer<Book>
    {  
        public bool Equals(Book x, Book y)
        {
            if (ReferenceEquals(x, y))
            {
                return true;
            }

            if (ReferenceEquals(x, null))
            {
                return false;
            }

            if (ReferenceEquals(y, null))
            {
                return false;
            }

            if (x.GetType() != y.GetType())
            {
                return false;
            }

            return x.Title == y.Title && x.Author == y.Author && x.PublishingHouse == y.PublishingHouse;
            
        }
        
        public int GetHashCode(Book obj)
        {
            return HashCode.Combine(obj.Title, obj.Author, obj.PublishingHouse);
        }
    }
}
