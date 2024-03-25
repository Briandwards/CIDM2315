using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            int points = 5;
            while (points > 0)
            {
                Console.WriteLine("****Rock Paper Scissors, Start!!****");
                Console.WriteLine($"You have {points} points");
                Console.WriteLine("Please input your choice: rock, paper or scissors.");
                string userChoice = Console.ReadLine();
                string computerChoice = GetComputerChoice();
                Console.WriteLine($"--> Your Decision: {userChoice}");
                Console.WriteLine($"--> Computer Decision: {computerChoice}");
                if (userChoice == computerChoice)
                {
                    Console.WriteLine("It's a Tie");
                }
                else if (IsWinningChoice(userChoice, computerChoice))
                {
                    points += 5;
                    Console.WriteLine("You win!");
                }
                else
                {
                    points -= 5;
                    Console.WriteLine("You Lose!");
                }
                Console.WriteLine($"--> Play again? Input y to continue, or n to exit");
                if (Console.ReadLine() != "y")
                {
                    break;
                }
            }
            Console.WriteLine("Thank you for playing!");
        }
        
        static string GetComputerChoice()
        {
            string[] choices = { "rock", "paper", "scissors" };
            Random rand = new Random();
            return choices[rand.Next(0, 3)];
        }

        static bool IsWinningChoice(string user, string computer)
        {
            if (user == "rock" && computer == "scissors")
            {
                return true;
            }
            else if (user == "paper" && computer == "rock")
            {
                return true;
            }
            else if (user == "scissors" && computer == "paper")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}