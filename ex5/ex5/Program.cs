using System;

class Program
{
    static void Main()
    {
        int par = 0, impar = 0, pos = 0, neg = 0;
        string resp = "N";

        while (resp != "S")
        {
            Console.Write("Número: ");
            int n = int.Parse(Console.ReadLine());

            if (n % 2 == 0) par++;
            else impar++;

            if (n > 0) pos++;
            if (n < 0) neg++;

            Console.Write("Encerrar? S/N: ");
            resp = Console.ReadLine().ToUpper();
        }

        Console.WriteLine($"Pares: {par}");
        Console.WriteLine($"Ímpares: {impar}");
        Console.WriteLine($"Positivos: {pos}");
        Console.WriteLine($"Negativos: {neg}");
    }
}