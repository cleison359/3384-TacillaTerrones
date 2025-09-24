using System;

class Programa
{
    static void Main()
    {
        double nota = 8.5;

        if (nota >= 9.0)
        {
            Console.WriteLine("Excelente");
        }
        else if (nota >= 7.0)
        {
            Console.WriteLine("Bueno");
        }
        else if (nota >= 6.0)
        {
            Console.WriteLine("Suficiente");
        }
        else
        {
            Console.WriteLine("Reprobado");
        }
    }
}
