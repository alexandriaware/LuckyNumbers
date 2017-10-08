using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string playAgain = "";

            do
            {
                Console.Clear();
                Console.WriteLine("Welcome to Lucky Numbers! Here's how the game is played: \nYou pick a range between two numbers, like 1 and 13. Then, you \npick six numbers within that range.");
                Console.WriteLine("Your opponent, the computer, will also pick six numbers within your range. If \nyou guess all six of the computer's numbers correctly, you will win $60,000!");
                Console.WriteLine("Are you ready to play? \n");

                int firstNum;
                int secondNum;

                //continue asking for numbers until they are not equal to each other
                do
                {
                    Console.WriteLine("Please enter the first number in your range:");
                    firstNum = int.Parse(Console.ReadLine());

                    Console.WriteLine("Please enter the second number in your range:");
                    secondNum = int.Parse(Console.ReadLine());
                    if (secondNum <= firstNum)
                    {
                        Console.WriteLine("Invalid. Please enter two different numbers.\n");

                    }
                }
                while (secondNum <= firstNum);

                Console.WriteLine("Thank you.");


                //user array
                int[] luckyGuess = new int[6];

                Console.WriteLine("Please guess a number from within your range.");

                for (int i = 0; i < luckyGuess.Length; i++)
                {
                    luckyGuess[i] = int.Parse(Console.ReadLine());
                    if (luckyGuess[i] < firstNum || luckyGuess[i] > secondNum)
                    {
                        Console.WriteLine("Please enter a valid number. Pick a number between " + firstNum + " and " + secondNum + ".");
                    }
                    else
                    {
                        Console.WriteLine("Please enter another number!");
                    }
                }

                Console.WriteLine("Thank you!\n");


                //winning numbers array
                int correctGuesses = 0;

                Random rando = new Random();
                int[] luckyNum = new int[6];

                for (int i = 0; i < luckyNum.Length; i++)
                {
                    int winningNumber;

                    do
                    {
                        winningNumber = rando.Next(secondNum) + 1;
                    }
                    while (luckyNum.Contains(winningNumber));
                    luckyNum[i] = winningNumber;
                    
                    ////commented out original code for stretch task
                    //int winningNumber = rando.Next(secondNum) + 1;
                    //luckyNum[i] = winningNumber;
                }


                foreach (int winningNumber in luckyNum)
                {
                    Console.WriteLine("Lucky Number: " + winningNumber);
                }


                //compare the user and computer's arrays
                foreach (int number in luckyGuess)
                {
                    if (luckyNum.Contains(number))
                    {
                        correctGuesses++;
                    }
                }

                Console.WriteLine("You guessed " + correctGuesses + " correctly!");



                //jackpot is equal to $60,000
                int jackpot = 60000;
                int prizeMoney = correctGuesses * 10000;

                if (correctGuesses == 6)
                {
                    Console.WriteLine("CONGRATULATIONS! You guessed them all right! $" + jackpot + " to you!");
                }
                else if (correctGuesses == 0)
                {
                    Console.WriteLine("You lose. No correct guesses.");
                }
                else
                {
                    Console.WriteLine("You have won $" + prizeMoney + "!");
                }


                Console.WriteLine("Would you like to play again?");
                playAgain = Console.ReadLine().ToLower();
            }

            while (playAgain == "yes");

            if (playAgain == "no")
            {
                Console.WriteLine("Thanks for playing.");
            }
            


            








        }
    }
}
