
void adivinar()  //Metodo, no esta llamando nada
{
    const int oportunidades = 4;
    int NumeroCPU,NumeroUser;
    byte Intentos, BanderaControl;
    string Linea;
    //Generar numeros de 1 al 20 unicamente.
    Random random = new Random();

    //do
    //{
    //    NumeroCPU = Convert.ToInt32(rand.Next(100));
    //    //Console.WriteLine(NumeroCPU);
    //} while (!(((NumeroCPU >= 1) & (NumeroCPU <= 20))));
    NumeroCPU = random.Next(1, 21);

    //Proceso
    Intentos = 1;
    BanderaControl = 0;

    do
    {
        Console.WriteLine("\nEstoy pensando en un numero cual sera?");
        Linea = Console.ReadLine();
        NumeroUser = Convert.ToInt32(Linea);
        if (NumeroCPU == NumeroUser)
        {
            Console.WriteLine("\nAdivinaste!!!");
            BanderaControl = 1;
        }
        else
        {
            if ((NumeroUser > NumeroCPU)) 
            {
                Console.WriteLine("\nTe excediste el numero ingresdo es mas grande que el numero a adivinar");
            }else {
                Console.WriteLine("\nIngresaste un numero mas pequenio que el numero a adivinar");
            }
            Intentos++;
        }
    } while ((Intentos <= oportunidades) & (BanderaControl == 0)); //0 = apagado, 1 = encendido si esta encendido sale del ciclo
    if (BanderaControl == 0)
    {
        Console.WriteLine($"El Numero a adivinar es: {NumeroCPU}");
    }
}



void mayor_menor()
{
    int mayor = 0;
    int numero = 0;
    int menor = 10;
    Random random = new Random();
    for (int i = 0; i < 5; i++) {
        numero = random.Next(10);
        Console.WriteLine(numero);
        if(numero > mayor)
        {
            mayor = numero;
        }
            if(numero < menor)
            {
                menor = numero;
            }
        
        
    }
    Console.WriteLine("El mayor es = " + mayor);
    Console.WriteLine("El menor es = " + menor);
}

void catcher()
{
    int cantidad = 0;
    Console.WriteLine("Ingrese unca cantidad");
    try
    {
        cantidad = int.Parse(Console.ReadLine());
        cantidad = cantidad / 0;

    }catch(FormatException fex)
    {
        Console.WriteLine("Ingreso mal el numero " + fex.Message);
    }catch(Exception ex)
    {
        Console.WriteLine("Hay un error de otro tipo: "+ex.Message);
    }
    if(cantidad > 0)
    {
        Console.WriteLine("cantidad ingresada = " + cantidad);
    }
}

void Arreglo()
{
    //int[] numero = new int[7]; //definimos y creamos el arreglo 
    ////int suma = 0;
    ////numero[0] = 45;
    ////numero[1] = 50;
    ////numero[2] = 68;
    ////numero[3] = 70;
    ////numero[4] = 86;
    ////numero[5] = 92;
    ////numero[6] = 69;
    ////int elementos = numero.Length;
    ///
    Random random = new Random();
    int CanGana = 2;
    List<string> ganadores = new List<string>();

    int elementos = 10;
    string[] nombres = new string[elementos];
    nombres[0] = "Maria";
    nombres[1] = "Juan";
    nombres[2] = "Pedro";
    nombres[3] = "Pepe";
    nombres[4] = "Bobi";
    nombres[5] = "Julio";
    nombres[6] = "Juana";
    nombres[7] = "Clarence";
    nombres[8] = "Julian";
    nombres[9] = "Daniela";

    while (ganadores.Count < CanGana)
    {
        int indiceGana = random.Next(nombres.Length);
        string ganador = nombres[indiceGana];
        if (!ganadores.Contains(ganador))
        {
            ganadores.Add(ganador);
        }
    }
    Console.WriteLine("Los ganadores son:");
    foreach (string ganador in ganadores)
    {
        Console.WriteLine(ganador);
    }

    //int elementosN = nombres.Length;

    //for (int i = 0; i < 7; i++)
    //{
    //    suma = suma + numero[i];
    //    Console.WriteLine(numero[i]);
    //}

    //for (int i = 0; i < elementosN; i++)
    //{

    //    Console.WriteLine(nombres[i]);
    //}

    //Console.WriteLine("La sumatoria de las notas es de: " + suma);
    //Console.WriteLine("El Promedio es = " + suma / elementos);
    //Console.WriteLine("numero en posicion 2 = " + numero[2]);


}
Arreglo();
//catcher();
//mayor_menor ();
//adivinar();