using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppOOPWorkShop.Models.Data
{
    public class User
    {
        string firstName = string.Empty;
        string lastName = string.Empty;
        int userID;
        DateTime birthDate;
        int strikes;
        bool activeLoans = false;
        bool suspended = false;
        List<Loan> loans = new List<Loan>();
        //adressInfo
        //phone
        //email

        public User(string firstName, string lastName, DateTime birthDate)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.birthDate = birthDate;
        }
    }
}
