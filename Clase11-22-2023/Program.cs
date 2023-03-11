



void saludo(string nom_saludo)          //parametros
{
Console.WriteLine($"Hola {nom_saludo} gusto en saludarte");
}

void desglose(String nom)
{
    String nuevo = nom.ToUpper();
    string r = "";
    int longitud = nom.Length;
    

    for (int c = 0; c < nuevo.Length; c++)
    {
        Console.SetCursorPosition(10+c, 10);
        Console.Write(nuevo[c] + " ");
        r = r + nuevo[c].ToString().ToLower();
        Thread.Sleep(1500);
        //nom = nom.ToUpper();
    }

    
    Console.WriteLine("minusculas=" + r);

    //Console.WriteLine(nom[2]);

}
void reves(String nom2)
{
    String nuevo = nom2.ToUpper();
    string r = "";
    int longitud = nom2.Length; 

    for (int c = 5; c < nuevo.Length; c--)
    {
        Console.SetCursorPosition(10 + c, 10);
        Console.Write(nuevo[c] + " ");
        Thread.Sleep(1500);
        //nom = nom.ToUpper();
    }
}
int calculo(int edad)
    {
    int anio = 2023 - edad;
    return anio;
}
static bool palindromo(string nom);
{
    string r = "";
    for(int c = nuevo.Length;c > 0;c--)
    {
        
    }
}
if(palindromo("ana"))
{
    Console.WriteLine("es un palindromo");

}
else
{
    Console.WriteLine("Nel pastel");

}
 
    string nombre;
    int edad;
    int anio;
    desglose("Maria");
reves("Maria");
    Console.WriteLine("Cuale es tu nombre");
    nombre = Console.ReadLine();


    saludo(nombre);
    

Console.WriteLine($"Hola {nombre} gusto de saludarte");
Console.WriteLine("Cuantos anios tienes?");
edad = Convert.ToInt32(Console.ReadLine());
anio = calculo(edad);
Console.WriteLine($"Naciste en el anio: {anio}");
Console.WriteLine($"Waw {nombre} tienes {edad} anio es genial");

//nombre = Console.ReadLine();
