using System;

namespace SelectionStatementsConsoles
{
    class Program
    {
        static void Main(string[] args)
        {
            int favNumber = 6;

            Console.WriteLine("Guess the favorite number. Hint: below 10");
            int userGuess = int.Parse(Console.ReadLine());

            if (userGuess < favNumber)
            {
                Console.WriteLine("Too LOW!!!!");
            }
            else if (userGuess > favNumber)
            {
                Console.WriteLine("Too High!!!!");
            }
            else if (userGuess == favNumber)
            {
                Console.WriteLine("You were correct! Good Job!");
            }
            else
            {
                Console.WriteLine("Nevermind");
            }

            
            
            
            string subject = "C#";

            Console.WriteLine("Choose a subject");
            string userSubject = Console.ReadLine();

            switch(userSubject)
            {
                case "C#":
                    Console.WriteLine("You are in the right class");
                    break;
                case "Java":
                    Console.WriteLine("C# is better than Java");
                    break;
                    default:
                    Console.WriteLine("We teach coding here");
                    break;
        
            }
        }
    }
}
