using System;

class Programa
{
    static void Main()
    {
        int numero = -5;

        if (numero != 0)
        {
            if (numero > 0)
            {
                Console.WriteLine("El número es positivo.");
            }
            else
            {
                Console.WriteLine("El número es negativo.");
            }
        }
        else
        {
            Console.WriteLine("El número es cero.");
        }
    }
}
