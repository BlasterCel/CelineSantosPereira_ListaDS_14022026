using System;

class Program
{
    static void Main()
    {
        string resp = "N";

        while (resp != "S")
        {
            Console.Write("Usuário 1 - Dia: ");
            int d1 = int.Parse(Console.ReadLine());
            Console.Write("Usuário 1 - Mês: ");
            int m1 = int.Parse(Console.ReadLine());

            Console.Write("Usuário 2 - Dia: ");
            int d2 = int.Parse(Console.ReadLine());
            Console.Write("Usuário 2 - Mês: ");
            int m2 = int.Parse(Console.ReadLine());

            if (m1 < m2)
                Console.WriteLine("Usuário 1 primeiro");
            else if (m2 < m1)
                Console.WriteLine("Usuário 2 primeiro");
            else if (d1 < d2)
                Console.WriteLine("Usuário 1 primeiro");
            else if (d2 < d1)
                Console.WriteLine("Usuário 2 primeiro");
            else
                Console.WriteLine("Mesmo dia");

            Console.Write("\nEncerrar? S/N: ");
            resp = Console.ReadLine().ToUpper();
        }
    }
}