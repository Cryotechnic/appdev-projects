using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console; // Not to repeat Console.WriteLine every time


namespace MonkeyBusiness
{
    class Monkey
    {
        // Defining variables
        int[,] randomVals;
        public Monkey()
        {
            //this.RandomVals = randomVals;
        }

        // Definining properties
        public int[,] RandomVals
        {
            get { return randomVals; }
            set { randomVals = value; }
        }

        static void GenerateNumbers(int [,] randomVals)
        {
            randomVals = new int[3, 30];
            Random rand = new Random();

            for (int i = 0; i < 3; i++)
            {
                int x = i + 1;
                //Write("\n" + "Monkey {0}: ", x);
                for (int j = 0; j < 30; j++)
                {
                    randomVals[i, j] = rand.Next(10, 30);
                    //Write("{0}" + " ", randomVals[i, j]);
                    x++;
                }
            }
        }

        static void CalcAvg(int [,] randomVals)
        {
            int sum = randomVals.Cast<int>().Sum();
            double avg = sum / 30;
        }

         static void DisplayOutput(int [,] randomVals, double avg)
        {
            Write("The following table shows the food used by three monkeys during the month: ");
            Write("------------------------------------------------------------------------------------------------------------------------");
            for (int i = 0; i < randomVals.GetLength(0); i++)
            {
                int x = i + 1;
                Write("\n" + "Monkey {0}: ", x);
                for (int j = 0; j < randomVals.GetLength(1); j++)
                {
                    Write("{0}" + " ", randomVals[i, j]);
                }
            }
            Write("------------------------------------------------------------------------------------------------------------------------");
            Write("Average amount of food eaten per day by the entire family of monkeys: {0}", avg);

        }
    }
}
