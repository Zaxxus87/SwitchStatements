using System;

namespace SwitchStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            string subject;
            Console.WriteLine("What is your favorite " +
                "subject(Math/Science/History/English/Programming)");
            subject = Console.ReadLine();

            switch(subject)
            {
                case "Math":
                    Console.WriteLine("Knowing your Numbers");
                    break;
                case "Science":
                    Console.WriteLine("Matter of taste");
                    break;
                case "History":
                    Console.WriteLine("We don't want to repeat ourselves");
                    break;
                case "English":
                    Console.WriteLine("Is it two, to, or too");
                    break;
                default:
                    Console.WriteLine("Who doesn't like computers?");
                    break;
            }
        }
    }
}
