﻿using System.Linq.Expressions;

namespace c_oefenopdracht
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //3-24
            string Username01 = "alex";
            string Password01 = "sunshine";
            string Username02 = "emma";
            string Password02 = "haskell";

            Console.WriteLine("Enter username:");
            string ReaduserName = Console.ReadLine();
            Console.WriteLine("Enter Password:");
            string ReadPassword = Console.ReadLine();

            if(ReaduserName == Username01 && ReadPassword == Password01 || ReaduserName == Username02 && ReadPassword == Password02)
            {
                Console.WriteLine("succes");
            }
            else
            {
                Console.WriteLine("wrong log in information");
            }


            //3-28
            string input;
            do
            {
                input = Console.ReadLine();
                if (!string.IsNullOrEmpty(input))
                {
                    string[] parts = input.Split(' ');
                    Console.WriteLine(parts[parts.Length - 1]);
                }
            } while (!string.IsNullOrEmpty(input));


            //3-29
            string inputopdr29;
            Console.WriteLine("enter a int");
            List<int> ages = new List<int>();
            do
            {
                inputopdr29 = Console.ReadLine();
                
                if (!string.IsNullOrEmpty(inputopdr29))
                {
                    string[] parts = inputopdr29.Split(',');
                    string name = parts[0];
                    int age = int.Parse(parts[1]);
                    ages.Add(age);
                }
            } while (!string.IsNullOrEmpty(inputopdr29));
            int maxAge = ages[0];
            foreach (int age in ages)
            {
                if (age > maxAge)
                {
                    maxAge = age;
                }
            }
            Console.WriteLine("The oldest person is {0} years old.", maxAge);



            //3-30
            string inputopdr30;
            string[] nameAge;
            string oldestName = "";
            int oldestAge = 0;

            while (true)
            {
                Console.Write("Enter a name and age (or press Enter to finish): ");
                input = Console.ReadLine().Trim();

                if (string.IsNullOrEmpty(input))
                {
                    break;
                }

                nameAge = input.Split(',');

                string name = nameAge[0].Trim();
                int age = int.Parse(nameAge[1].Trim());

                if (age > oldestAge)
                {
                    oldestAge = age;
                    oldestName = name;
                }
            }

            Console.WriteLine($"The oldest person is {oldestName}, who is {oldestAge} years old.");
        }

    }
}

