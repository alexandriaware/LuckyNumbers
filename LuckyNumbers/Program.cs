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
            
            Console.WriteLine("Welcome to Lucky Numbers! Here's how the game is played: \nYou pick a range between two numbers, like 1 and 13. Then, you\n pick six numbers within that range.");
            Console.WriteLine("Your opponent, the computer, will also pick six numbers within your range. If \nyou guess all six of the computer's numbers correctly, you will win $60,000!");
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
            
            Console.WriteLine("Please guess a number from within your range.\n");
           
            for (int i = 0; i < luckyGuess.Length; i++)
            {
                luckyGuess[i] = int.Parse(Console.ReadLine());
                if (luckyGuess[i] < firstNum || luckyGuess[i] > secondNum)
                {
                    Console.WriteLine("Please enter a valid number. Pick a number between " + firstNum + " and " + secondNum + ".");
                }
                else
                {
                    Console.WriteLine("Please enter another number!\n");
                }
            }

            Console.WriteLine("Thank you!\n");

            //winning numbers array
            int correctGuesses = 0;

            Random rando = new Random();
            int[] luckyNum = new int[6];

            for (int i = 0; i < luckyNum.Length; i++)
            {
                int randomNumber = rando.Next(secondNum) + 1;
                luckyNum[i] = randomNumber;
            }
            
            foreach (int randomNumber in luckyNum)
            {
                Console.WriteLine("Lucky Number: " + randomNumber);
            }

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
            int prizeMoney = jackpot / correctGuesses;

            if (correctGuesses == 6)
            {
                Console.WriteLine("CONGRATULATIONS! You guessed them all right! $60,000 to you!");
            }
            else
            {
                Console.WriteLine("You have won $" + prizeMoney + "!");
            }


            
            
             






        }
    }
}
