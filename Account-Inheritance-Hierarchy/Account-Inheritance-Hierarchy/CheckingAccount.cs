using System;
using System.Collections.Generic;
using System.Text;
using static System.Console; // Not to repeat Console.WriteLine every time


namespace Account_Inheritance_Hierarchy
{
    class CheckingAccount : Account // Inheritance declaration
    {
        // Variable declaration
        private double fee; 

        // Constructor definition
        public CheckingAccount(string accNumber, double accBalance, double fee) : base(accNumber, accBalance)
        {
            this.fee = fee;
        }

        // Properties definition
        public double Fee
        {
            get { return fee; }
            set { this.fee = value; }
        }

        // Override for Debit from parent class Account
        public override bool Debit(double widthrawAmt)
        {
            if (base.Debit(widthrawAmt) == true)
            {
                this.accBalance -= fee;
            } else
            {
                WriteLine("CHECKING: Debit amount exceeded account balance.");
            }
            return true;
        }

        // Override for Credit from parent class Account
        public override void Credit(double addCredit)
        {
            this.accBalance += addCredit - fee;
        }

        // Displays account information to user
        public override string DisplayAccount()
        {
            string rFormattedAccNumber = String.Format($"| {"Account Number",-20} | {this.accNumber,-25} |");
            string rFormattedAccBalance = String.Format($"| {"Account Balance",-20} | {this.accBalance,25:C} |");
            string rFormattedAccFee = String.Format($"| {"Transaction Fee",-20} | {this.fee,25:C} |");

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("____________________________________________________");
            stringBuilder.AppendLine($"{"|",-14} CHECKING ACCOUNT {"|",20}");
            stringBuilder.AppendLine("|__________________________________________________|");
            stringBuilder.AppendLine(rFormattedAccNumber);
            stringBuilder.AppendLine(rFormattedAccBalance);
            stringBuilder.AppendLine(rFormattedAccFee);
            stringBuilder.AppendLine("|______________________|___________________________|");
            return stringBuilder.ToString();
        }
    }
}
