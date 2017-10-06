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

            Console.WriteLine("Thank you.\n");


            //user array
            int[] luckyGuess = new int[6];
            
            Console.WriteLine("Please guess a number from within your range.");
            //luckyGuess[0] = int.Parse(Console.ReadLine());

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

            //







        }
    }
}
