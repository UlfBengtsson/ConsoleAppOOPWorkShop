using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppOOPWorkShop.Models.Data
{
    public class User
    {
        string firstName = string.Empty;
        string lastName = string.Empty;
        int userID = 0;
        int age = 0;
        int strikes = 0;       
        bool activeLoans = false;
        List<Loan> loans = new List<Loan>();
    }
}
