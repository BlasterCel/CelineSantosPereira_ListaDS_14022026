using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite o primeiro número: ");
        int n1 = int.Parse(Console.ReadLine());

        Console.Write("Digite o segundo número: ");
        int n2 = int.Parse(Console.ReadLine());

        int me = n1;
        int ma = n2;

        if (n1 > n2)
        {
            me = n2;
            ma = n1;
        }

        int contador = 0;

        for (int i = me; i <= ma; i++)
        {
            if (i % 2 != 0)
            {
                contador++;
            }
        }

        Console.WriteLine("Quantidade de ímpares: " + contador);
        Console.ReadKey();
    }
}