using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            //#1
            Console.WriteLine("Enter 1st number");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 2nd number");
            int secondNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 3rd number");
            int thirdNumber = int.Parse(Console.ReadLine());

            Console.WriteLine(firstNumber + "  " + secondNumber + "  " + thirdNumber);
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();

            //#2
            Console.Clear();
            Console.WriteLine(5);
            Console.WriteLine(10);
            Console.WriteLine(21);
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();

            //#3
            Console.Clear();
            Console.WriteLine("Enter distance in santimeters");
            int distance = int.Parse(Console.ReadLine());
            int santimetersInMeter = 1000;
            int distanceInMeters = distance / santimetersInMeter;
            Console.WriteLine("Distance in meters = " + distanceInMeters);
            Console.WriteLine("Press enter to continue");
            Console.ReadKey();

            //#4
            Console.Clear();
            Console.WriteLine("Enter days");
            int days = int.Parse(Console.ReadLine());
            int daysInWeek = 7;
            int weeksInDays = days / daysInWeek;
            Console.WriteLine("Passed weeks = " + weeksInDays);
            Console.WriteLine("Press enter to continue");
            Console.ReadKey();

            //#5
            Console.Clear();
            Console.WriteLine("Enter number(two-digit)");
            int usingNumber = int.Parse(Console.ReadLine());
            int decade = 10;
            int size = 0;
            int sumOfNumbers = 0;
            int multiplyOfNumbers = 1;

            for (int i = usingNumber; i > 0; i /= decade)
            {
                size++;
            }

            if (size == 2)
            {
                int[] numbersInArray = new int[size];

                for (int i = 0, q = usingNumber; i < numbersInArray.Length; i++, q /= 10)
                {
                    numbersInArray[i] = q % 10;
                }
                for (int i = 0; i < size / 2; i++)
                {
                    int tmp = numbersInArray[i];
                    numbersInArray[i] = numbersInArray[size - i - 1];
                    numbersInArray[size - i - 1] = tmp;
                }
                int decadePosition = 2;
                int decadesCounter = numbersInArray[size - decadePosition];

                int unitPostition = 1;
                int unitsCounter = numbersInArray[size - unitPostition];


                for (int i = 0; i < numbersInArray.Length; i++)
                {
                    sumOfNumbers += numbersInArray[i];
                }
                for (int i = 0; i < numbersInArray.Length; i++)
                {
                    multiplyOfNumbers *= numbersInArray[i];
                }

                Console.WriteLine("Decade = " + decadesCounter);
                Console.WriteLine("Unit = " + unitsCounter);
                Console.WriteLine("Sum of all numbers = " + sumOfNumbers);
                Console.WriteLine("Multiply of all numbers = " + multiplyOfNumbers);
            }
            else
            {
                Console.WriteLine("Wrong number");
            }
            Console.WriteLine("Press enter to continue");
            Console.ReadKey();

            //#6
            Console.Clear();
            Console.WriteLine("Enter 1st boolean value");
            bool A = Boolean.Parse(Console.ReadLine());
            Console.WriteLine("Enter 2nd boolean value");
            bool B = Boolean.Parse(Console.ReadLine());
            Console.WriteLine("Enter 3rd boolean value");
            bool C = Boolean.Parse(Console.ReadLine());
            bool result;

            result = A || B;
            result = A && B;
            result = C || B;


            Console.WriteLine("Result is " + result);
            Console.WriteLine("Press enter to continue");
            Console.ReadKey();

            //#7 
            Console.Clear();
            Console.WriteLine("Enter radius");
            int radius = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter side of a square");
            int squareSide = int.Parse(Console.ReadLine());

            double circleArea = 3.14 * radius * radius;
            int squareArea = squareSide * squareSide;

            if (circleArea > squareArea)
            {
                Console.WriteLine("Circle area is larger");
                Console.WriteLine("Circle area is " + circleArea);
            }
            else if (circleArea < squareArea)
            {
                Console.WriteLine("Square area is larger");
                Console.WriteLine("Square area is " + squareArea);
            }
            else
            {
                Console.WriteLine("Areas are equal");
                Console.WriteLine("Circle area is " + circleArea);
                Console.WriteLine("Square area is " + squareArea);
            }
            Console.WriteLine("Press enter to continue");
            Console.ReadKey();

            //#8
            Console.Clear();
            Console.WriteLine("Enter 1st mass");
            int firstMass = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 1st volume");
            int firstVolume = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 2nd mass");
            int secondMass = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 2nd volume");
            int secondVolume = int.Parse(Console.ReadLine());

            double firstDensity = firstMass / (double)firstVolume;
            double secondDensity = secondMass / (double)secondVolume;

            if (firstDensity > secondDensity)
            {
                Console.WriteLine("1st density is larger");
                Console.WriteLine("1st density is " + firstDensity);
            }
            else if (firstDensity < secondDensity)
            {
                Console.WriteLine("2nd density is larger");
                Console.WriteLine("2nd density is " + secondDensity);
            }
            else
            {
                Console.WriteLine("Densitys are equal");
                Console.WriteLine("1st density is " + firstDensity);
                Console.WriteLine("2nd density is " + secondDensity);
            }
            Console.WriteLine("Press enter to continue");
            Console.ReadKey();

            //#9
            Console.Clear();
            Console.WriteLine("Enter 1st resistance");
            int firstResistance = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 1st voltage");
            int firstVoltage = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 2nd resistance");
            int secondResistance = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 2nd voltage");
            int secondVoltage = int.Parse(Console.ReadLine());

            double firstAmperage = firstResistance / (double)firstVoltage;
            double secondAmperage = secondResistance / (double)secondVoltage;

            if (firstAmperage > secondAmperage)
            {
                Console.WriteLine("1st amperage is larger");
                Console.WriteLine("1st amperage is " + firstAmperage);
            }
            else if (firstAmperage < secondAmperage)
            {
                Console.WriteLine("2nd amperage is larger");
                Console.WriteLine("2nd amperage is " + secondAmperage);
            }
            else
            {
                Console.WriteLine("Amperages are equal");
                Console.WriteLine("1st amperage is " + firstAmperage);
                Console.WriteLine("2nd amperage is " + secondAmperage);
            }
            Console.WriteLine("Press enter to continue");
            Console.ReadKey();

            //#10
            Console.Clear();
            int numberFrom = 20;
            int numberTo = 35;
            for (int i = numberFrom; i < numberTo; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            Console.WriteLine("Enter 2nd number(more than 10)");
            int numberMoreThanTen = int.Parse(Console.ReadLine());
            int ten = 10;
            Console.WriteLine();

            if (numberMoreThanTen > ten)
            {
                for (int i = ten; i < numberMoreThanTen; i++)
                {
                    Console.WriteLine(Math.Pow(i, 2));
                }
            }
            else
            {
                Console.WriteLine("Wrong number");
            }

            Console.WriteLine("Enter 1st number(less than 50)");
            int numberLessThenFifty = int.Parse(Console.ReadLine());
            int fifty = 50;
            Console.WriteLine();

            if (numberLessThenFifty < fifty)
            {
                for (int i = fifty; i > numberLessThenFifty; i--)
                {
                    Console.WriteLine(Math.Pow(i, 3));
                }
            }
            else
            {
                Console.WriteLine("Wrong number");
            }

            Console.WriteLine("Enter 1st number");
            numberFrom = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 2nd number(more than 1st)");
            numberTo = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (numberFrom < numberTo)
            {
                for (int i = numberFrom; i < numberTo; i++)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                Console.WriteLine("Wrong number");
            }
            Console.WriteLine("Press enter to exit");
            Console.ReadLine();
        }
    }
}
