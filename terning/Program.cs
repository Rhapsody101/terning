using System;
using System.Collections.Generic;

namespace terning
{
    class Program
    {
        public static Random random = new Random();
        public static int randomNumber(int min, int max) { return random.Next(min, max); }
        public static int vv = 1;
        public static int six;

        static void Main()
        {
            Console.WriteLine("Please input how many dice's :");
            int userInput = Convert.ToInt32(Console.ReadLine());
            engine(userInput);
        }

        public static int engine(int terninger)
        {
            for (int i = 1; i <= terninger; i++)
            {
                while(true)
                {
                    six = randomNumber(1, 7);
                    Console.WriteLine("Terning nummer " + i + " slår nu.. og slog " + six);
                    if (six == 6)
                        break;
                    vv++;
                }
            }
            Console.WriteLine("Det tog " + vv + " kast.");
            return 0;
        }
    }
}
