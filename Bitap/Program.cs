using System;

namespace Bitap
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type your text>>");
            string text = Console.ReadLine();

            Console.WriteLine("Type the pattern>>");
            string pattern = Console.ReadLine();

            int maxDistance = 3; 

            int result = FuzzyBitap(text, pattern, maxDistance);

            if (result != -1)
            {
                Console.WriteLine($"Pattern is found at position {result}!");
            }
            else
            {
                Console.WriteLine("No common pattern found!");
            }
        }

        static int FuzzyBitap(string text, string pattern, int maxDistance)
        {
            for (int i = 0; i <= text.Length - pattern.Length; i++)
            {
                int errors = 0;
                for (int j = 0; j < pattern.Length; j++)
                {
                    if (text[i + j] != pattern[j])
                    {
                        errors++;
                        if (errors > maxDistance)
                            break;
                    }
                }

                if (errors <= maxDistance)
                    return i;
            }

            return -1;
        }
    }
}