using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console; // Not to repeat Console.WriteLine every time


namespace MonkeyBusiness
{
    class Program
    {
        double [,] randomVals;
        static double[,] GenerateNumbers()
        {
            double [,] randomVals = new double[3, 30];
            Random rand = new Random();

            for (int i = 0; i < 3; i++)
            {
                int x = i + 1;
                double count = 0;
                //Write("\n" + "Monkey {0}: ", x);
                for (int j = 0; j < 30; j++)
                {
                    randomVals[i, j] = rand.Next(10, 30);
                    //Write("{0}" + " ", randomVals[i, j]);
                    count += 
                    x++;
                }
            }
            return randomVals;
        }

        static double CalcAvg(double[,] randomVals)
        {
            int sum = randomVals.Cast<int>().Sum();
            double avg = sum / 30;
            return avg;
        }

        static double leastFood(double[,] randomVals)
        {

            return 0.0;
        }

         static void DisplayOutput(double[,] randomVals)
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
            Write("Average amount of food eaten per day by the entire family of monkeys: {0}", CalcAvg(randomVals));
            ReadLine();
        }
        static void Main(string[] args)
        {

            double[,] monkeyRand = GenerateNumbers();
            DisplayOutput(monkeyRand);
            ReadLine(); // Wait for input before close
        }
    }
}
