using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Target_Heart_Rate_Calculator
{
    class Program
    {
        static void Main(string[] args) 
        {
            // Asks for user input to assign values
            WriteLine("Enter your first name: ");
            string fname = ReadLine();
            WriteLine("Enter your last name: ");
            string lname = ReadLine();
            WriteLine("Enter your birth year: ");
            int byear = int.Parse(ReadLine());
            WriteLine("Enter your height (in inches): ");
            int height = int.Parse(ReadLine());
            WriteLine("Enter your weight (in pounds): ");
            int weight = int.Parse(ReadLine());

            // Creates objects
            HeartRate hr = new HeartRate(fname, lname, byear);
            HealthProfile hp = new HealthProfile(fname, lname, byear, height, weight);

            // Displays objects and relative data to user
            WriteLine(hp.DisplayPatientRecord());
            WriteLine(hr.DisplayPatientRecord());
            Console.ReadLine(); // Wait for input before close
        }
    }
}
