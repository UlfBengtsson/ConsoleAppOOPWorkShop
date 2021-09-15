using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppOOPWorkShop.Models.Data
{
    
    class Auther
    {
        public string firstName;
        public string lastName;
        public DateTime birthDate;
        public List<string> genres;
        public List<Book> books;

        private Auther(string firstName, string lastName, DateTime birthDate)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.birthDate = birthDate; 
        }

        public Auther(string firstName,string lastName, string genre, DateTime birthDate) : this(firstName, lastName, birthDate)
        {
            this.genres = new List<string> { genre };            
        }

        public Auther(string firstName, string lastName, List<string> genres, DateTime birthDate) : this(firstName, lastName, birthDate)
        {
            this.genres = genres;
            //this.genres = new List<string> { book };
        }

    }//end of auther
    
}//end of namespace
