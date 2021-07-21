using System;
using System.Collections.Generic;
using System.Text;

namespace rps
{
    public class Game
    {
        private int playerScore;
        private int computerScore;
        private Random random;
        private string computerMove;
        private string playerMove;

        public Game()
        {
            playerScore = 0;
            computerScore = 0;
            random = new Random();
        }

        public void Start()
        {
            Console.Title = "Rock, Paper, Scissors";
            Console.WriteLine(Console.Title);
            Console.WriteLine("\nLet's play Rock, Paper, Scissors!" +
                              "\n\t=> Enter your choice when the pop up appears");
            Console.Write("\nAre you ready to begin? (yes/no) : ");
            string choice = Console.ReadLine();

            if (choice == "yes" || choice == "y")
            {
                Console.WriteLine("OK, starting the game now!");
                PlayRound();
            }
            else if (choice == "no" || choice == "n")
            {
                Console.WriteLine("OK, thank you for playing!");
            }
            else
            {
                Console.WriteLine("Incorrect response, please try again!");
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }

        private void PlayRound()
        {
            int randomInt = random.Next(1, 4);

            Console.Clear();
            Console.Write("Enter (r)ock, (p)aper or (s)cissors : ");
            playerMove = Console.ReadLine().Trim().ToLower();

            switch (randomInt)
            {
                case 1:
                    computerMove = "rock";

                    if (playerMove == "rock" || playerMove == "r")
                    {
                        Console.WriteLine("You have chosen : rock");
                        Console.WriteLine($"The Computer chose : {computerMove}");
                        Console.WriteLine("You have both tied!");
                    }

                    else if (playerMove == "paper" || playerMove == "p")
                    {
                        Console.WriteLine("You have chosen : paper");
                        Console.WriteLine($"The Computer chose : {computerMove}");
                        Console.WriteLine("You Win!");
                        playerScore++;
                    }

                    else if (playerMove == "scissors" || playerMove == "s")
                    {
                        Console.WriteLine("You have chosen : scissors");
                        Console.WriteLine($"The Computer chose : {computerMove}");
                        Console.WriteLine("The Computer Wins!");
                        computerScore++;
                    }

                    else
                    {
                        Console.WriteLine("Please choose a correct option!");
                        Console.ReadLine();
                        PlayRound();
                    }
                    break;

                case 2:
                    computerMove = "paper";

                    if (playerMove == "rock" || playerMove == "r")
                    {
                        Console.WriteLine("You have chosen : rock");
                        Console.WriteLine($"The Computer chose : {computerMove}");
                        Console.WriteLine("The Computer Wins!");
                        computerScore++;
                    }

                    else if (playerMove == "paper" || playerMove == "p")
                    {
                        Console.WriteLine("You have chosen : paper");
                        Console.WriteLine($"The Computer chose : {computerMove}");
                        Console.WriteLine("You have both tied!");
                    }

                    else if (playerMove == "scissors" || playerMove == "s")
                    {
                        Console.WriteLine("You have chosen : scissors");
                        Console.WriteLine($"The Computer chose : {computerMove}");
                        Console.WriteLine("You Win!");
                        playerScore++;
                    }
                    
                    else
                    {
                        Console.WriteLine("Please choose a correct option!");
                        Console.ReadLine();
                        PlayRound();
                    }
                    break;

                case 3:
                    computerMove = "scissors";

                    if (playerMove == "rock" || playerMove == "r")
                    {
                        Console.WriteLine("You have chosen : rock");
                        Console.WriteLine($"The Computer chose : {computerMove}");
                        Console.WriteLine("You Win!");
                        playerScore++;
                    }

                    else if (playerMove == "paper" || playerMove == "p")
                    {
                        Console.WriteLine("You have chosen : paper");
                        Console.WriteLine($"The Computer chose : {computerMove}");
                        Console.WriteLine("The Computer Wins!");
                        computerScore++;
                    }

                    else if (playerMove == "scissors" || playerMove == "s")
                    {
                        Console.WriteLine("You have chosen : scissors");
                        Console.WriteLine($"The Computer chose : {computerMove}");
                        Console.WriteLine("You have both tied!");
                    }

                    else
                    {
                        Console.WriteLine("Please choose a correct option!");
                        Console.ReadLine();
                        PlayRound();
                    }
                    break;

                default:
                    Console.WriteLine("Incorrect Choice!");
                    break;
            }

            Console.WriteLine($"\nPlayer Score : {playerScore}\nComputer Score : {computerScore}");

            AskToPlayAgain();
        }

        private void AskToPlayAgain()
        {
            Console.Write("\nWould you like to play again? (yes/no) : ");
            string answer = Console.ReadLine().Trim().ToLower();

            if (answer == "yes" || answer == "y")
            {
                PlayRound();
            }
            else
            {
                Console.WriteLine("OK, thank you for playing!");
            }
        }
    }
}
