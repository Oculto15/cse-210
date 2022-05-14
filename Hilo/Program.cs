using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    class Program
    {
        int answer;
        int guess;
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Opening();
            p.randomize();

            while (true)
            {
                p.userData();
                p.Display();
            }

        }

        //method for the introduction
        private void Opening()
        {
            Console.WriteLine("Welcome to the Guessing Game! Pless any key to continue!");
            Console.ReadLine();
        }

        //method for getting user input
        private void userData()
        {
            Console.WriteLine("Enter your guess number.");
            guess = int.Parse(Console.ReadLine());

        }

        //method for display
        private void Display()
        {

            if (guess == answer)
            {
                Console.WriteLine("Congratulation. You won!");
                Console.WriteLine("Score: ");
                PlayAgain();
            }
            else if (guess > answer)
            {
                Console.WriteLine("Your guess is high");
            }
            else if (guess < answer)
            {
                Console.WriteLine("Your guess is low");
            }

        }

        private void Score()
        {
            int[] score = new int[100];

        }

        private void AverageScore()
        {


        }

        //method for playing again question
        private void PlayAgain()
        {
            Console.WriteLine("Do you want to play again? Yes or No");
            string respond = Console.ReadLine().ToLower();
            if (respond == "yes")
            {
                Opening();
                randomize();

                while (true)
                {
                    userData();
                    Display();
                }

            }
            else if (respond == "no")
            {
                EndProgram();
            }
            else
            {
                Console.WriteLine("You enter a wrong respond.");
                Console.WriteLine("Will automatic exit you");
                EndProgram();
            }
        }

        //method for the random number  generator
        private void randomize()
        {
            Random rand = new Random();
            answer = rand.Next(1, 13);
        }

        //method for end program
        private void EndProgram()
        {
            Console.WriteLine("\n");
            Console.WriteLine("Press any key to Exit");
            Console.ReadKey();
        }

    }
}
