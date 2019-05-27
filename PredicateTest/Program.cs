using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PredicateTest
{
    class Program
    {
        static List<int> randomNumbers = new List<int>();
        static private Predicate<int> _divisibilityCheck;

        static void Main(string[] args)
        {
            Console.WriteLine("type number between 2-9");
            int divisor = Convert.ToInt32(Console.ReadLine());
            generateNumbers();
            switch (divisor)
            {
                case 2:
                    _divisibilityCheck = (number => number % 2 == 0);
                    break;
                case 3:
                    _divisibilityCheck = (number => number % 3 == 0); 
                    break;
                case 4:
                    _divisibilityCheck = (number => number % 4 == 0);
                    break;
                case 5:
                    _divisibilityCheck = (number => number % 5 == 0);
                    break;
                case 6:
                    _divisibilityCheck = (number => number % 6 == 0);
                    break;
                case 7:
                    _divisibilityCheck = (number => number % 7 == 0);
                    break;
                case 8:
                    _divisibilityCheck = (number => number % 8 == 0);
                    break;
                case 9:
                    _divisibilityCheck = (number => number % 9 == 0);
                    break;
                default:
                    break;
            }

            Console.WriteLine();
            Console.WriteLine($"--- first numbers is {GetNumber(_divisibilityCheck)} ---");
            Console.ReadLine();
        }

        private static void generateNumbers()
        {
            Random rand = new Random();
            for (int i = 0; i < 50; i++)
            {
                randomNumbers.Add(rand.Next(0, 1000));
            }
        }

        public static int GetNumber(Predicate<int> divisibilityCheck)
        {
            int firstNumber = randomNumbers.FindIndex(divisibilityCheck);
            return randomNumbers[firstNumber];
        }

        //public static bool divisibleBy2(int number)
        //{
        //    if ((number % 2) == 0)
        //        return true;
        //    else
        //        return false;
        //}

        //public static bool divisibleBy3(int number)
        //{
        //    if ((number % 3) == 0)
        //        return true;
        //    else
        //        return false;
        //}

        //public static bool divisibleBy4(int number)
        //{
        //    if ((number % 4) == 0)
        //        return true;
        //    else
        //        return false;
        //}

        //public static bool divisibleBy5(int number)
        //{
        //    if ((number % 5) == 0)
        //        return true;
        //    else
        //        return false;
        //}

        //public static bool divisibleBy6(int number)
        //{
        //    if ((number % 6) == 0)
        //        return true;
        //    else
        //        return false;
        //}

        //public static bool divisibleBy7(int number)
        //{
        //    if ((number % 7) == 0)
        //        return true;
        //    else
        //        return false;
        //}

        //public static bool divisibleBy8(int number)
        //{
        //    if ((number % 8) == 0)
        //        return true;
        //    else
        //        return false;
        //}

        //public static bool divisibleBy9(int number)
        //{
        //    if ((number % 9) == 0)
        //        return true;
        //    else
        //        return false;
        //}


    }
}
