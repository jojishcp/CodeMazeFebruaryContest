using System;

namespace FebruaryContestEntry
{
    class Program
    {
        const char block = '▓';
        const int row = 15;
        const int column = 30;

        static void Main(string[] args)
        {
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine();

            for (var i = 0; i < row; i++)
            {
                for (var j = 0; j < column; j++)
                {
                    Console.ForegroundColor = (j == 0 || j == column - 1 || i == 0 || i == row - 1) ? ConsoleColor.DarkGreen : ConsoleColor.DarkYellow;
                    Console.Write(block);
                }

                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
