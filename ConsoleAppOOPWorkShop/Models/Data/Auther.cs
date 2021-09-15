using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppOOPWorkShop.Models.Data
{
    
    class Auther
    {
        public string firstName;
        public string lastName;
        public DateTime age;
        public List<string> genres;

        private Auther(string firstName, string lastName, DateTime age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }

        public Auther(string firstName,string lastName, string genre, DateTime age) : this(firstName, lastName, age)
        {
            this.genres = new List<string> { genre };
        }

        public Auther(string firstName, string lastName, List<string> genres, DateTime age) : this(firstName, lastName, age)
        {
            this.genres = genres;
        }

    }//end of auther
    
}//end of namespace
