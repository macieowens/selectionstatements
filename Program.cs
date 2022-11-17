using System;


namespace selection_statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int favoriteNumber = 11;

            //Console.WriteLine("Guess my favorite number, hint: 1 and 1 together");
            //int userGuess = int.Parse(Console.ReadLine());

            //if (userGuess < favoriteNumber)
            //{
            //Console.WriteLine("Too Low! Try again");
            //}
            //else if (userGuess > favoriteNumber)
            //{
            //Console.WriteLine("Too high! Try again");       
            //}
            //else if (userGuess == favoriteNumber)
            //{
            //Console.WriteLine("Good Job!");
            //}
            //else
            //{
            //Console.WriteLine("Stop trying");
            //}

            string subject = "C";

            Console.WriteLine("What's your favorite subject?");
            string userSubject = Console.ReadLine();

            switch (userSubject)
            {
                case "C#":
                    Console.WriteLine("Congradulations! You are in the right class");
                    break;
                case "Java":
                    Console.WriteLine("C# is better than Java.");
                    break;
                default:
                    Console.WriteLine("We teach and learn code.");
                    break;
            }

        }
    }
}
