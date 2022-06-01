using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswdGenerator
{
    public static class Outils
    {
        public static int AskNumberPositiveNotNull(string question)
        {
            return AskNumberBetween(question, 1, int.MaxValue);
        }
        public static int AskNumberBetween(string question, int min, int max)
        {
            while (true)
            {
                int number = AskNumber(question);

                if ((number >= min) && (number <= max))
                {
                    return number;
                }
                Console.WriteLine($"Wrong Choice please enter a number between {min} and {max} !");
            }
        }
        public static int AskNumber(string question)
        {
            while (true)
            {
                Console.Write(question);
                string answer = Console.ReadLine();
                try
                {
                    int answerInt = int.Parse(answer);
                    return answerInt;
                }
                catch
                {
                    Console.WriteLine("Please enter a number");
                }
            }
        }
    }
}
