using System.Linq.Expressions;

namespace c_oefenopdracht
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
            
        }
    }
}