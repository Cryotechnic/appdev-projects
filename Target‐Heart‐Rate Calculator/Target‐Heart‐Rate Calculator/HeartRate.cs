// Importing libraries
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console; // Not to repeat Console.WriteLine every time

namespace Target_Heart_Rate_Calculator
{
    class HeartRate
    {
        // Declaring variables
        public string fname; 
        public string lname;
        public int byear;
        private static protected int age;
        private int CURRENTYEAR = DateTime.Today.Year;

        // Constructor
        public HeartRate(string fname, string lname, int byear)
        {
            this.fname = fname;
            this.lname = lname;
            this.byear = byear;
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
            get {
                int maxRate = 220 - (CURRENTYEAR - byear);
                double fifty = maxRate / 2;
                double eightyFive = maxRate * 0.85;
                string range = fifty + "—" + eightyFive;
                return range;
            }
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

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("____________________________________________________");
            stringBuilder.AppendLine($"{"|",-7} PATIENT HEART RATE RECORDS {"|",17}");
            stringBuilder.AppendLine("|__________________________________________________|");
            stringBuilder.AppendLine(rFormattedLastName);
            stringBuilder.AppendLine(rFormattedBYear);
            stringBuilder.AppendLine(rFormattedAge);
            stringBuilder.AppendLine(rFormattedMaxHeartrate);
            stringBuilder.AppendLine(rFormattedTargetHeartrate);
            stringBuilder.AppendLine("|______________________|___________________________|");
            return stringBuilder.ToString();
        }
    }
}
