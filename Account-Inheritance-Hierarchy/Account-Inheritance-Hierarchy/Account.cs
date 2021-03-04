using System;
using System.Collections.Generic;
using System.Text;
using static System.Console; // Not to repeat Console.WriteLine every time

namespace Account_Inheritance_Hierarchy
{
    class Account
    {
        // Defining variables
        protected string accNumber;
        protected double accBalance;

        // Constructor definition
        public Account(string accNumber, double accBalance)
        {
            if (accBalance <= 0)
            {
                WriteLine("Account initial balance amount should be a positive value.");
            } else
            {
                this.AccNumber = accNumber;
                this.AccBalance = accBalance;
            }
        }

        // Defining properties
        public string AccNumber
        {
            get { return accNumber; }
            set { accNumber = value; }
        }

        public double AccBalance
        {
            get { return accBalance; }
            set { accBalance = value; }
        }

        // Adds credit to account balance
        public virtual void Credit(double addCredit)
        {
            this.accBalance += addCredit;
        }

        // Widthraws amount from debit account, returns error if not enough money is found
        public virtual bool Debit(double widthrawAmt)
        {
            if (widthrawAmt < accBalance)
            {
                this.AccBalance = this.AccBalance - widthrawAmt;
                return true;
            } else 
            {
                WriteLine("ACCOUNT: Debit amount exceeded account balance.");
                return false;
            }
        }

        // Display result to user
        public virtual string DisplayAccount()
        { 
        
            string rFormattedAccNumber = String.Format($"| {"Account Number",-20} | {this.accNumber,-25} |");
            string rFormattedAccBalance = String.Format($"| {"Account Balance",-20} | {this.accBalance,25:C} |");

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("____________________________________________________");
            stringBuilder.AppendLine($"{"|",-7} ACCOUNT {"|",30}");
            stringBuilder.AppendLine("|__________________________________________________|");
            stringBuilder.AppendLine(rFormattedAccNumber);
            stringBuilder.AppendLine(rFormattedAccBalance);
            stringBuilder.AppendLine("|______________________|___________________________|");
            return stringBuilder.ToString();
        }
    }
}
