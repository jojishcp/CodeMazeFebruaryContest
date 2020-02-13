using System;

namespace FebruaryContestEntry
{
    class Program
    {
        const char block = '▓';

        static void Main(string[] args)
        {

            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine();
            for (var i = 0; i < 15; i++)
            {
                for (var j = 0; j < 30; j++)
                {
                    Console.ForegroundColor = (j == 0 || j == 29 || i == 0 || i == 14) ? ConsoleColor.DarkGreen : ConsoleColor.DarkYellow;
                    Console.Write(block);
                }

                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
