
using System;
using System.Timers;
using System.Transactions;
{
    Console.WriteLine("Calcularemos el Area de un circulo solo ingrese el radio de dicho circulo: ");
    double radio = Convert.ToDouble(Console.ReadLine());
    while (radio < 0)
    {
        Console.WriteLine("\nEL radio tiene que ser positivo intente denuevo porfavor");
        double radio1 = Convert.ToDouble(Console.ReadLine());
        radio = radio1;
    }
    double radio2 = radio * radio;
    double area = Math.PI * radio2;
    Console.WriteLine($"\nEl Area del ciruclo es: {area}");
    Console.SetCursorPosition(0, 15);
    Console.WriteLine("Presione ENTER para continuar...");
    Console.ReadLine();
    Console.Clear();
}

{
    Console.WriteLine("Calcularems el perimetro de un triangulo a traves de su anchura y altura");
    Console.WriteLine("\nIngrese el Ancho del triangulo: ");
    double ancho = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("\nIngrese la Altura dle triangulo: ");
    double altura = Convert.ToDouble(Console.ReadLine());
    while (ancho < 0 || altura < 0)
    {
        Console.WriteLine("\nTanto el Ancho como el Alto deben der positivos para poder realizar la operacion");
        Console.WriteLine("\nIngrese el Ancho del triangulo: ");
        double ancho1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("\nIngrese la Altura del triangulo: ");
        double altura1 = Convert.ToDouble(Console.ReadLine());
        altura = altura1;
        ancho = ancho1;

    }
    double altura2 = altura * altura;
    double ancho2 = ancho / 2;
    double ancho3 = ancho2 * ancho2;
    double L = Math.Sqrt(altura2 + ancho3);
    double P = L + ancho + L;

    Console.WriteLine($"\nEl Parametro de un triangulo es: {P}");
    
    Console.WriteLine("\n\n\n\nPresione ENTER para continuar...");
    Console.ReadLine();
    Console.Clear();
}

{
    {
        int[] lista = { 15, 18, 2, 36, 12, 78, 5, 6, 9 };


        double promedio = LPromedio(lista);


        Console.WriteLine($"El promedio de la lista es: {promedio}");
    }


    static double LPromedio(int[] lista)
    {

        int suma = lista.Sum();


        double promedio = (double)suma / lista.Length;


        return promedio;

    }
    Console.SetCursorPosition(0, 15);
    Console.WriteLine("Presione ENTER para continuar...");
    Console.ReadLine();
    Console.Clear();
}

{
    Console.WriteLine("Ingrese una cantidad para determinar si es par o impar y si dicha cantidad ingresada contiene decimales se aproximaran a enteros ");
    double N = Convert.ToDouble(Console.ReadLine());
    int numero = (int)Math.Round(N);
    if (numero % 2 == 0)
    {
        Console.WriteLine("\nEl número {0} es par", numero);
    }
    else
    {
        Console.WriteLine("\nEl número {0} es impar", numero);
    }
    Console.SetCursorPosition(0, 15);
    Console.WriteLine("Presione ENTER para continuar...");
    Console.ReadLine();
    Console.Clear();
}

{
    Console.WriteLine("Ingresa el Texto que deseas y luego se te mostrara en Mayusculas.\n");
    string text = Console.ReadLine();
    string mayus = text.ToUpper();
    Console.WriteLine($"\n{mayus}");
    Console.SetCursorPosition(0, 15);
    Console.WriteLine("Presione ENTER para continuar...");
    Console.ReadLine();
    Console.Clear();
}

{
    Console.WriteLine("\nIngrese las cordenadas de los dos puntos para saber la distancia entre dichos puntos");
    Console.WriteLine("\nIngrese las cordenadas de A en x: ");
    double Ax = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("\nIngrese las cordenadas de A en y: ");
    double Ay = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("\nIngrese las cordenadas de B en x: ");
    double Bx = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("\nIngrese las cordenadas de B en y: ");
    double By = Convert.ToDouble(Console.ReadLine());
    double A = Ax - Bx;
    double B = Ay - By;
    double A2 = A * A;
    double B2 = B * B;
    double total = A2 + B2;
    double distancia = Math.Sqrt(total);
    Console.WriteLine($"\nLa distancia entre ambos puntos es de: {distancia}");
    Console.SetCursorPosition(0, 20);
    Console.WriteLine("Presione ENTER para continuar...");
    Console.ReadLine();
    Console.Clear();
}

{
    Console.WriteLine("Ingrese hasta que cantidad desea sumar los numeros naturales recuerde que no se admiten numeros inferiores a 1: ");
    int n = int.Parse(Console.ReadLine());
    int suma = 0;
    while (n <= 0)
    {
        Console.WriteLine("El numero que Ingresaste es negativo ingresa un numero positivo mayor que 0");
        n = int.Parse(Console.ReadLine());
    }

    for (int i = 1; i <= n; i++)
    {
        suma += i;
    }
    Console.WriteLine("\nEl total de la suma es de: " + suma);
    Console.WriteLine("\n\n\n\nPresione ENTER para continuar...");
    Console.ReadLine();
    Console.Clear();
}


{
    Console.WriteLine("Ingrese el numero del que desea saber su factorial tienes que tener en cuenta que si el numero es meyor que 65 te dara 0 ");
    double N = Convert.ToDouble(Console.ReadLine());
    int numero = (int)Math.Round(N);
    long factorial = 1;

    while (numero >= 66)
    {
        Console.WriteLine("El numeor que a ingresado es demaciado grande porfavor ingrese un numero que no pase de 65");
        numero = int.Parse(Console.ReadLine());
    }
    for (int f = 1; f <= numero; f++)
    {
        factorial = factorial * f;
    }

    Console.WriteLine($"\nEl Factorial de {numero} es: {factorial}");

    Console.WriteLine("\n\n\n\nPresione ENTER para continuar...");
    Console.ReadLine();
    Console.Clear();

}






