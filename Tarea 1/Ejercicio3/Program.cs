
{
    long n1, n2;

    Console.WriteLine("Ingresar numeros mayores a 19 porfavor.\n");
    Console.WriteLine("Ingrese el 1er numero: ");
    n1 = long.Parse(Console.ReadLine());
    Console.WriteLine("Ingresar el 2do numero: ");
    n2 = long.Parse(Console.ReadLine());

    long suma = n1 + n2;
    long resta = n1 - n2;
    long multi = n1 * n2;

    Console.WriteLine($"Entonces {n1} + {n2} es: {suma} ");
    Console.WriteLine($"Entonces {n1} - {n2} es: {resta} ");
    Console.WriteLine($"Entonces {n1} * {n2} es: {multi} ");

    Console.ReadKey();

}

