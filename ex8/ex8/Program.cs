using System;

class Program
{
    static void Main()
    {
        Console.Write("Salário: R$");
        double sal = double.Parse(Console.ReadLine());

        Console.Write("Código: ");
        int cod = int.Parse(Console.ReadLine());

        double re = 0;
        string cargo = "";

        switch (cod)
        {
            case 101: cargo = "Administrador"; re = 0.80; break;
            case 102: cargo = "Engenheiro"; re = 0.65; break;
            case 103: cargo = "Médico"; re = 0.60; break;
            case 104: cargo = "Outro"; re = 0.55; break;
            default: Console.WriteLine("Código inválido!"); return;
        }

        double novo = sal + (sal * re / 100);

        Console.WriteLine($"\nCargo: {cargo}");
        Console.WriteLine($"Antigo: R${sal:F2}");
        Console.WriteLine($"Novo: R${novo:F2}");
        Console.WriteLine($"Diferença: R${novo - sal:F2}");
    }
}