using System;

class Programa
{
    static void Main()
    {
        int opcion = 2;

        switch (opcion)
        {
            case 1:
                Console.WriteLine("Has seleccionado la opción 1");
                break;
            case 2:
                Console.WriteLine("Has seleccionado la opción 2");
                break;
            case 3:
                Console.WriteLine("Has seleccionado la opción 3");
                break;
            default:
                Console.WriteLine("Opción no válida");
                break;
        }
    }
}
