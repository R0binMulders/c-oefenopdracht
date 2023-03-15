using System.Linq.Expressions;

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


        }

    }
}

