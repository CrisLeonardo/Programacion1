using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese el 1er numero de dos cifras: ");
        byte n1 = Byte.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el 2do numero de dos cifras: ");
        byte n2 = Byte.Parse(Console.ReadLine());
        ushort resultado = (ushort)(n1 * n2);

        Console.WriteLine("El total de la Multiplicacion de las dos cantidades es: " + resultado);
    }
}