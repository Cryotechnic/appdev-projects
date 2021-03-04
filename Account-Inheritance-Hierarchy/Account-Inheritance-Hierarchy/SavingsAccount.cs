using System;
using System.Collections.Generic;
using System.Text;
using static System.Console; // Not to repeat Console.WriteLine every time


namespace Account_Inheritance_Hierarchy
{
    class SavingsAccount : Account // Definition of child-parent
    {
        // Definition of variables
        private decimal interestRate;

        // Definition of constructor
        public SavingsAccount (string accNumber, double accBalance, decimal interestRate) : base(accNumber, accBalance)
        {
            this.interestRate = interestRate;
        }

        // Defining properties
        public decimal InterestRate
        {
            get { return interestRate; }
            set { interestRate = value; }
        }

        // Method calculates interest and returns error if the user does not have enough funds
        public decimal CalculateInterest()
        {
            Double interest = (double)interestRate * accBalance;
            return (decimal)interest;
        }

        // Output account information to user
        public override string DisplayAccount()
        {
            string rFormattedAccNumber = String.Format($"| {"Account Number",-20} | {this.accNumber,-25} |");
            string rFormattedAccBalance = String.Format($"| {"Account Balance",-20} | {this.accBalance,25:C} |");
            string rFormattedAccInterest = String.Format($"| {"Interest Rate:",-20} | {this.interestRate,25:P} |");

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("____________________________________________________");
            stringBuilder.AppendLine($"{"|",-15} SAVINGS ACCOUNT {"|",20}");
            stringBuilder.AppendLine("|__________________________________________________|");
            stringBuilder.AppendLine(rFormattedAccNumber);
            stringBuilder.AppendLine(rFormattedAccBalance);
            stringBuilder.AppendLine(rFormattedAccInterest);
            stringBuilder.AppendLine("|______________________|___________________________|");
            return stringBuilder.ToString();
        }
    }
}
