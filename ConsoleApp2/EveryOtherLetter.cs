using System;

namespace EveryOtherLetter
{
    class EveryOtherLetter
    {
        private static string? body;
        private static int lengthOfString;

        static void GetString()
        {
            body = Console.ReadLine();
            lengthOfString = body.Length;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter a word or phrase to make every other letter uppercase: ");
            int i = 0;

            do
            {
                GetString();
                if (body == null || lengthOfString <= 0)
                {
                    Console.Write("Please enter a word or phrase: ");
                    continue;
                }
            }
            while (body == null || lengthOfString <= 0);

                Console.WriteLine($"Every other letter, starting with {body[0]}, capitalized: \n");
            do
            {
                string startOfString = Convert.ToString(body[i]);
                if (i % 2 == 0)
                {
                    startOfString = startOfString.ToUpper();
                }
                Console.Write(startOfString);
                i++;
            }
            while (i < lengthOfString);
        }
    }
}
