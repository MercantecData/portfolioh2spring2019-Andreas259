using System;
using System.Threading;
using System.Threading.Tasks;

namespace Multithreading
{
    class GuessNumber
    {
        bool terminate;
        public GuessNumber()
        {
            Console.WriteLine("Please guess a number between 1-10");

            Task countdown = Countdown();

            Random random = new Random();
            int randomNumber = random.Next(1, 10);
            int guess = 0;
            while (guess != randomNumber)
            {
                guess = Convert.ToInt32(Console.ReadLine());

                if (countdown.IsCompleted)
                {
                    Console.WriteLine("Time has passed, try again");
                }
                else
                {
                    if (guess == randomNumber)
                    {
                        terminate = true;
                        Console.WriteLine("You guessed the right number");
                    }
                    else if (guess < randomNumber)
                    {
                        Console.WriteLine("Your guess is to low, try again");
                    }
                    else if (guess > randomNumber)
                    {
                        Console.WriteLine("Your guess is to high, try again");
                    }
                }
            }

            countdown.Wait();
        }

        public async Task Countdown()
        {
            for (int i = 9; i >= 0; i--)
            {
                if (terminate) break;
                Console.WriteLine("You have {0} seconds left", i + 1);
                await Task.Delay(1000);
            }
        }
    }
}
