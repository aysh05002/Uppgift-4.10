using System;

class program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hur många X per grupp");
        int X = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Hur många O per grupp");
        int O = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Hur många O-mönster per rad");
        int o = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Hur många rader");
        int x = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= x; i++)
        {
            for (int j = 1; j <= o; j++)
            {
                for (int k = 1; k <= X; k++)
                {
                    Console.Write("X");
                }
                Console.Write("-");
                for (int l = 1; l <= O; l++)
                {
                    Console.Write("O");
                }
                Console.Write("-");
            }
            for (int k = 1; k <= X; k++)
            {
                Console.Write("X");
            }
            Console.WriteLine();
        }
    }
}