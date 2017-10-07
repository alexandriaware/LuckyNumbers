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
            
            Console.WriteLine("Welcome to Lucky Numbers! Your goal is to guess as many numbers within\na range correctly as possible!\n");
            int firstNum;
            int secondNum;

            //continue asking for numbers until they are not equal to each other
            do
            {
                Console.WriteLine("Please enter the first number in your range:");
                firstNum = int.Parse(Console.ReadLine());

                Console.WriteLine("Please enter the second number in your range:");
                secondNum = int.Parse(Console.ReadLine());
                if (firstNum == secondNum)
                {
                    Console.WriteLine("Invalid. Please enter two different numbers.\n");

                }
            }
            while (firstNum == secondNum);

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


            //jackpot
            string jackpot = "60,000";
            int jackpotNum = 60000;
            int winNum;

            for(int i = 0; i < luckyGuess.Length; i++)
            {
                if(luckyNum.Contains(luckyGuess[i]))
                {

                }
            }

            
            
             






        }
    }
}
