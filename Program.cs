using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tasktwoQ1
{
    class Program
    {
        static void Main(string[] args)
        {
            int grade = 0;
            int tryCounter = 0;

            Random ran = new Random();
            int RandomNumber = ran.Next(50, 75);

            Console.Write("Guess the number between 50 and 75 : ");
            int UserNumber = Convert.ToInt32(Console.ReadLine());
            tryCounter++;

            if (RandomNumber == UserNumber)
            {
                grade = 10;
            }

            while (UserNumber != RandomNumber)
            {

                Console.WriteLine("Try Again!");
                Console.Write("Guess the number between 50 and 75 : ");
                tryCounter++;
                UserNumber = Convert.ToInt32(Console.ReadLine());
                if (tryCounter == 2 && RandomNumber == UserNumber)
                {
                    grade = 7;
                }
                else if (tryCounter == 3 && RandomNumber == UserNumber)
                {
                    grade = 5;
                }
            }

            Console.WriteLine($"Your grade is {grade} and You've tried to guess the number {tryCounter} times!");

        }
    }
}
