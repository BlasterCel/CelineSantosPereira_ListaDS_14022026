using System;

class Program
{
    static void Main()
    {
        double soma = 0;

        for (int i = 1; i <= 10; i++)
        {
            Console.Write($"Nota {i}: ");
            double not = double.Parse(Console.ReadLine());

            if (not < 0 || not > 10)
            {
                Console.WriteLine("Nota errada! Digite 0 a 10.");
                i--;
            }
            else
            {
                soma += not;
            }
        }

        Console.WriteLine($"Média: {soma / 10}");
        Console.ReadKey();
    }
}