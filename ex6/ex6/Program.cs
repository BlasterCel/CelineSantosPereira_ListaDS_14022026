using System;

class Program
{
    static void Main()
    {
        string resp = "N";

        while (resp != "S")
        {
            Console.Write("Horas trabalhadas: ");
            int n = int.Parse(Console.ReadLine());

            int e = 0;
            int sal = n * 10;

            if (n > 50)
            {
                e = (n - 50) * 10;
                sal = sal + e;
            }

            Console.WriteLine($"Total: R${sal}");
            Console.WriteLine($"Excedente: R${e}");

            Console.Write("Encerrar? S/N: ");
            resp = Console.ReadLine().ToUpper();
        }
    }
}