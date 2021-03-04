using System;
using System.Text;
using static System.Console; // Not to repeat Console.WriteLine every time

namespace Account_Inheritance_Hierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            // Asks for user input to assign values
            WriteLine("Enter your account number: ");
            string accNumber = ReadLine();
            WriteLine("Enter your account balance: ");
            double accBalance = double.Parse(ReadLine());
            WriteLine("Enter the account interest rate: ");
            decimal interestRate = decimal.Parse(ReadLine());

            // Creates objects
            CheckingAccount checkAcc = new CheckingAccount(accNumber, accBalance, 1.5);
            SavingsAccount savAcc = new SavingsAccount(accNumber, accBalance, interestRate);

            // Displays objects and relative data to user
            WriteLine("\nDisplaying initial Savings Account Information");
            WriteLine(savAcc.DisplayAccount());
            WriteLine("Saving Account After Interest Calculation: ");
            double interestAmt = (double)savAcc.CalculateInterest();
            savAcc.AccBalance = savAcc.AccBalance + interestAmt;
            WriteLine(savAcc.DisplayAccount());

            // Performs debit operation on checking account
            WriteLine("Displaying initial Checking Account Information");
            WriteLine(checkAcc.DisplayAccount());
            WriteLine("Performing Debit operation of 20.00$");
            checkAcc.Debit(20.00);
            WriteLine(checkAcc.DisplayAccount());
            WriteLine("Performing Debit operation of 40.00$");
            checkAcc.Debit(40.00);
            WriteLine(checkAcc.DisplayAccount());
            WriteLine("Performing Debit operation of 60.00$");
            checkAcc.Debit(60.00);
            WriteLine(checkAcc.DisplayAccount());

            // Performs credit operation on checking 
            WriteLine("Performing Credit operation of 30.00$");
            checkAcc.Credit(30.00);
            WriteLine(checkAcc.DisplayAccount());
            WriteLine("Performing Credit operation of 50.00$");
            checkAcc.Credit(50.00);
            WriteLine(checkAcc.DisplayAccount());
            WriteLine("Performing Credit operation of 70.00$");
            checkAcc.Credit(70.00);
            WriteLine(checkAcc.DisplayAccount());

            ReadLine(); // Wait for input before close
        }
    }
}
