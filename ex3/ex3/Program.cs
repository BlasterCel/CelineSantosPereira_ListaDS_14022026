using System;

class Program
{
    static void Main()
    {
        int ma = 0;

        for (int i = 1; i <= 15; i++)
        {
            Console.Write($"Número {i}: ");
            int n = int.Parse(Console.ReadLine());

            if (i == 1 || n > ma)
            {
                ma = n;
            }
        }

        Console.WriteLine($"Maior número: {ma}");
        Console.ReadKey();
    }
}