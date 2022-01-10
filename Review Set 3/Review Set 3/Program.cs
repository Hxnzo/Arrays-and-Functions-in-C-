/*
    Start
        delcare variable numgrades
        declare variable rnd for random
        use for loop to fill array with 10 random numbers
        displays the third mark
        displays average mark
            makes a method to calculate the average mark and then returns a value
        displays all the marks from lowest to highest
            uses a method to check all the numbers then puts them in order from lowest to highest
        displays all marks from highest to lowest
            uses a method to check all the numbers then puts them in order from highest to lowest
        display all odd marks
            uses a method and modulus divides the numbers and if it equals to 1 then it returns the odd numbers
        display all even marks
            uses a method and modulus divides the numbers and if it equals to 0 then it returns the even numbers
        display all prime numbers
            calculates what the prime numbers are and then  returns every prime number, if no prime number is there then it stays blank
    End
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review_Set_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //an array will hold a group of similar variables
            const int NUMGRADES = 10;

            Random rnd = new Random();

            int[] examMark = new int[NUMGRADES];

            //fill array with 10 random exam marks.

            for (int i = 0; i < NUMGRADES; i++)
            {
                examMark[i] = rnd.Next(0, 101);
            }

            //displays third mark
            Console.Write("The third mark: ");
            Console.WriteLine(examMark[2].ToString());

            //displays average mark
            Console.Write("The average mark: ");
            Console.WriteLine(CalcAverage(examMark));

            //displays marks from lowest to highest
            Console.Write("Marks from lowest to highest: ");
            
            for(int i = 0; i < NUMGRADES; i++)
            {
                Console.WriteLine(sortLowToHigh(examMark)[i].ToString());
            }

            //displays marks from highest to lowest
            Console.Write("Marks from highest to lowest: ");

            for (int i = 0; i < NUMGRADES; i++)
            {
                Console.WriteLine(sortHighToLow(examMark)[i].ToString());
            }

            //displays all odd marks
            Console.WriteLine("Only the odd marks: ");
            outputOnlyOdd(examMark);

            //displays all even marks
            Console.WriteLine("Only the even marks: ");
            outputOnlyEven(examMark);

            //displays all prime numbers
            Console.WriteLine("Only the prime number marks: ");
            outputOnlyPrime(examMark);

            //prevents program from closing
            Console.ReadKey();
        }

        static double CalcAverage(int[] args)
        {
            //declares variable
            double avg = 0;

            //for loop runs and calculates the average of all marks
            for(int i = 0; i < args.Length; i++)
            {
                avg += args[i];
            }

            //calculates the average
            avg = avg / args.Length;

            //returns the variable as average mark
            return avg;
        }


        static int[] sortLowToHigh(int[] args)
        {
            //declares variables
            int temp = 0;
            bool isSorted = true;

            do
            {
                //sets as true
                isSorted = true;

                //for loop runs sorts the marks from lowest to highest
                for (int i = 0; i < args.Length - 1; i++)
                {
                    if (args[i] > args[i + 1])
                    {
                        temp = args[i];
                        args[i] = args[i + 1];
                        args[i + 1] = temp;
                        isSorted = false;
                    }
                }
            } while (isSorted == false);

            //returns value
            return args;
        }


        static int[] sortHighToLow(int[] args)
        {
            //declares variables
            int temp = 0;
            bool isSorted = true;

            do
            {
                isSorted = true;

                //runs to sort high to low
                for (int i = 0; i < args.Length - 1; i++)
                {
                    if (args[i] < args[i + 1])
                    {
                        temp = args[i];
                        args[i] = args[i + 1];
                        args[i + 1] = temp;
                        isSorted = false;
                    }
                }
            } while (isSorted == false);

            return args;
        }


        static void outputOnlyOdd(int[] args)
        {
            //displays all odd numbers
            for(int i = 0; i < args.Length - 1; i++)
            {
                if(args[i]%2 == 1)
                {
                    Console.WriteLine(args[i].ToString());
                }
            }
        }


        static void outputOnlyEven(int[] args)
        {
            //displays all even numbers
            for (int i = 0; i < args.Length - 1; i++)
            {
                if (args[i] % 2 == 0)
                {
                    Console.WriteLine(args[i].ToString());
                }
            }
        }


        static void outputOnlyPrime(int[] args)
        {
            bool isPrime = true;

            //displays all prime numbers
            for (int i = 0; i < args.Length - 1; i++)
            {
                isPrime = true;
                for (int j = 1; j < args[i]; j++)
                {
                    if(args[i]/j != 1 && args[i]/j != args[i] && args[i] != 0)
                    {
                        isPrime = false;
                    }
                }

                if(isPrime)
                {
                    Console.WriteLine(args[i].ToString());
                }
            }
        }

    }
}
