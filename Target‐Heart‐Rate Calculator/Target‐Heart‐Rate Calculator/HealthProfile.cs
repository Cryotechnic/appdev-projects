// Importing libraries
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console; // Not to repeat Console.WriteLine every time

namespace Target_Heart_Rate_Calculator
{
    class HealthProfile
    {
        // Declaring variables
        public double height;
        public double weight;
        public double bmi;
        public string fname;
        public string lname;
        public int byear;
        private static protected int age;
        private int CURRENTYEAR = DateTime.Today.Year;

        // Constructor
        public HealthProfile(string fname, string lname, int byear, double height, double weight)
        {
            this.fname = fname;
            this.lname = lname;
            this.byear = byear;
            this.height = height;
            this.weight = weight;
        }

        // Properties definition
        public string Fname
        {
            get { return fname; }
            set { fname = value; }
        }

        public string Lname
        {
            get { return lname; }
            set { lname = value; }
        }

        public int Byear
        {
            get { return byear; }
            set { byear = value; }
        }

        // Calculates Age from current year using DateTime
        public int Age
        {
            get { return age = CURRENTYEAR - byear; }
        }

        // Calculates Max Heart rate using DateTime 
        public int MaxHeartrate
        {
            get { return 220 - (CURRENTYEAR - byear); }
        }

        // Calculates Target Heart Rate using various mathematical equations
        public string TargetHeartrate
        {
            get
            {
                int maxRate = 220 - (CURRENTYEAR - byear);
                double fifty = maxRate / 2;
                double eightyFive = maxRate * 0.85;
                string range = fifty + "—" + eightyFive;
                return range;
            }
        }
        
        // Finds BMI given weight and height
        public double FindBmi(double weight, double height)
        { 
            return bmi = (weight * 703) / (height * height);
        }

        // Prints indicator based on calculated BMI value from previous method
        public string GiveBmiIndicator(double bmi)
        {
            if (bmi < 18.5)
            {
                return " Underweight";
            } else if (bmi >= 18.5 && bmi <= 24.9) {
                return " Normal";
            } else if (bmi >= 25 && bmi <= 29.9)
            {
                return " Overweight";
            } else if (bmi > 30)
            {
                return " Obese"; 
            }
            return " N/A";
        }


        // Display Patient Record to user console
        public string DisplayPatientRecord()
        {
            string name = lname + ", " + fname;
            string rFormattedLastName = String.Format($"| {"Patient Name",-20} | {name,-25} |");
            string rFormattedBYear = String.Format($"| {"Patient Birth Year",-20} | {byear,25:D} |");
            string rFormattedAge = String.Format($"| {"Patient Age",-20} | {Age,25:D} |");
            string rFormattedMaxHeartrate = String.Format($"| {"Max Heartrate",-20} | {MaxHeartrate,25:F} |");
            string rFormattedTargetHeartrate = String.Format($"| {"Target Heartrate",-20} | {TargetHeartrate,25:F} |");
            string rFormattedBmiValue = String.Format($"| {"Person BMI Value",-20} | {FindBmi(weight, height),25:F} |");
            string rFormattedBmi = String.Format($"| {"BMI Text Value",-20} | {GiveBmiIndicator(bmi),25:F} |");

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("____________________________________________________");
            stringBuilder.AppendLine($"{"|",-7} PATIENT HEART RATE RECORDS {"|",17}");
            stringBuilder.AppendLine("|__________________________________________________|");
            stringBuilder.AppendLine(rFormattedLastName);
            stringBuilder.AppendLine(rFormattedBYear);
            stringBuilder.AppendLine(rFormattedAge);
            stringBuilder.AppendLine(rFormattedMaxHeartrate);
            stringBuilder.AppendLine(rFormattedTargetHeartrate);
            stringBuilder.AppendLine(rFormattedBmiValue);
            stringBuilder.AppendLine(rFormattedBmi);
            stringBuilder.AppendLine("|______________________|___________________________|");
            return stringBuilder.ToString();
        }
    }
}
