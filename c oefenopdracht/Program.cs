﻿using System.Linq.Expressions;

namespace c_oefenopdracht
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Hello, World!");

            //opdracht 1-2
            Console.WriteLine("Once upon a time\r\n");
            Console.WriteLine("i was falling in love");
            Console.WriteLine("Now i'm falling apart");

            // opdracht 1-3
            Console.WriteLine("Once upon a time\n" +
                "I WAS FALLING IN LOVE  \n" +
                "now im only falling apart ");

            //opdracht 1-4
            string message = "Passport and toothbrush!";
            Console.WriteLine(message);

            //opdracht 1-5
            string name = "Ada Lovelace";
            Console.WriteLine("hello" + name);

            // opdracht 1-6
             var naam = Console.ReadLine();
            Console.WriteLine(naam);

            // opdracht 1-7
            var naam2 = Console.ReadLine();
            Console.WriteLine(naam2 + naam2 + naam2);

            // opdracht 1-8

            Console.WriteLine("What is your name?");
                var askname = Console.ReadLine();
            Console.WriteLine("Hello" + askname);

            // opdracht 1-9
            Console.WriteLine("Hello how are you?");
            var askq1 = Console.ReadLine();
            Console.WriteLine("thats interesting tell me more" );
            var askq2 = Console.ReadLine();
            Console.WriteLine("thank you for sharing");

            //opdracht 1-10
            Console.WriteLine("I will tell a story, but I need some information." );
            Console.WriteLine("Give a name for main character:");
            var askq3 = Console.ReadLine();
            Console.WriteLine("Give the character a profession:");
            var askq4 = Console.ReadLine();
            Console.WriteLine("Once upon a time there was a" + askq4 + "called" + askq3);
            Console.WriteLine("On her way to work," + askq3 + "often pondered what being" + askq4 + "meant to them.");
            Console.WriteLine("When you work as a" + askq4 + "you meet interesting people.");
            Console.WriteLine(askq3 + "heir work as" + askq4 + "The end.");



            //excericse van opdracht 2
            Console.WriteLine("week 2 --------------------------------------------");

            //opdracht2-1
            int opdr21first = 4 ;
            int sum = opdr21first * opdr21first;
            Console.WriteLine(sum);

            int opdr21second = 5;
            int sum = opdr21second * opdr21second;
            Console.WriteLine(sum);

            int opdr21third = 3;
            int sum = opdr21third * opdr21third;
            Console.WriteLine(sum);


            int opdr22first = 5;
            int opdr22second = 10;
            int opdr22firstsum = opdr22first + opdr22second;
            double squareRoot = Math.Sqrt(opdr22firstsum);
            Console.WriteLine(squareRoot);

            int number = 42;
            double squareRoot = Math.Sqrt(number);
            Console.WriteLine(squareRoot);

            int number = 42;
            double squareRoot = Math.Sqrt(number);
            Console.WriteLine(squareRoot);
            */


            
            //2-5
            Console.Write("Enter an integer: ");
            int input = Convert.ToInt32(Console.ReadLine());

            int sum = 1;
            while (sum <= input)
            {
                Console.WriteLine(sum);
                sum++;
            }

            //2-8
            int number8, sum8 = 0, count = 0, evenCount = 0, oddCount = 0;

            Console.Write("Give numbers: ");

            while ((number = Convert.ToInt32(Console.ReadLine())) != -1)
            {
                sum8 += number8;
                count++;

                if (number8 % 2 == 0)
                {
                    evenCount++;
                }
                else
                {
                    oddCount++;
                }
            }

            if (count > 0)
            {
                double average = (double)sum / count;
                Console.WriteLine("The sum of the numbers is: " + sum);
                Console.WriteLine("The count of the numbers is: " + count);
                Console.WriteLine("The average of the numbers is: " + average);
                Console.WriteLine("The count of even numbers is: " + evenCount);
                Console.WriteLine("The count of odd numbers is: " + oddCount);
            }
            else
            {
                Console.WriteLine("No numbers were entered.");
            }

            Console.WriteLine("Thx! Bye!");

            //2-9
            Console.Write("Enter the number of times to print the phrase: ");
            int numberOfTimes = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < numberOfTimes; i++)
            {
                PrintPhrase();
            }
            //2-11
            int number11 = 10;
            PrintUntilNumber(number);

            //12
             int number12 = 10;
             PrintFromNumberToOne(number);

            //2-13
            int numerator = 10;
            int denominator = 3;
            Division(numerator, denominator);

            //2-14
            int beginning = 1;
            int end = 20;
            DivisibleByThreeInRange(beginning, end);

        }
        //2-10
        public static void PrintPhrase()
        {
            Console.WriteLine("In a hole in the ground there lived a method.");
        }

        //2-11
        public static void PrintUntilNumber(int number11)
        {
            for (int i = 1; i <= number11; i++)
            {
                Console.Write(i + " ");
            }
        }

        //2-12
        public static void PrintFromNumberToOne(int number12)
        {
            for (int i = number12; i >= 1; i--)
            {
                Console.Write(i + " ");
            }
        }

        //2-13
        public static void Division(int numerator, int denominator)
        {
            double result = (double)numerator / denominator;
            Console.WriteLine("Result: " + result);
        }

        //2-14
        public static void DivisibleByThreeInRange(int beginning, int end)
        {
            Console.Write("Numbers divisible by 3 in range [" + beginning + ", " + end + "]: ");
            for (int i = beginning; i <= end; i++)
            {
                if (i % 3 == 0)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }

