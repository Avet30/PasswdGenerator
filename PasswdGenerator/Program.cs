using System;
using PasswdGenerator;

namespace PasswdGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            const int NbOfPasswords = 10;
            int lengthOfPasswd = Outils.AskNumberPositiveNotNull("Length of Password : ");
            Console.WriteLine();

            int ChoiceOfAlphabet = Outils.AskNumberBetween("Would like a password with :\n" +
                "1 - Only lowercase characters\n" +
                "2 - lowercase and uppercase characters\n" +
                "3 - characters and numbers\n" +
                "4 - characters, numbers and special characters\n" +
                "Your choice : ", 1, 4);


            string lowercase = "abcdefghijklmnopqrstuvxyz";
            string uppercase = lowercase.ToUpper();
            string numbers = "123456789";
            string specialCaracters = "!@#$%";
            string alphabet = lowercase + uppercase + numbers + specialCaracters;
            string password = "";
            
            Random random = new Random();

            if (ChoiceOfAlphabet == 1)
            {
                alphabet = lowercase;
            }
            else if (ChoiceOfAlphabet == 2)
            {
                alphabet = lowercase + uppercase;
            }
            else if (ChoiceOfAlphabet == 3)
            {
                alphabet = lowercase + uppercase + numbers;
            }
            else
            {
                alphabet = lowercase + uppercase + numbers + specialCaracters;
            }

            int lenghtOfAlphabet = alphabet.Length;

            for(int j = 0; j < NbOfPasswords; j++)
            {
                password = "";
                for (int i = 0; i < lengthOfPasswd; i++)
                {
                    int index = random.Next(0, lenghtOfAlphabet);
                    password += alphabet[index];
                  
                }
                Console.WriteLine($"Password : {password}");
            }           
        }
    }
}
