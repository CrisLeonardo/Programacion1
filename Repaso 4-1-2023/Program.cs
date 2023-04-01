

void arreglos()
{
    string[] nombre = new string[]
    {
        "Fernanda","Melvin","Luis","Brandon","Yamileth",
    };

    { 
    int[] notas = new int[] {
        70,90,43,85,30,
    };

        int min = notas[0];
        int max = notas[0];
        int x = 0;
        int x1 = 0;
        for (int i = 0; i < notas.Length; i++)
        {
            if (notas[i] < min)
            {
                min = notas[i];
                x1 = i;
            }
            if (notas[i] > max)
            {
                max = notas[i];
                x = i;
            }
        }
        Console.WriteLine("El número más pequeño es {0} y es de {1}", min, nombre[x1]);
        Console.WriteLine("El número más grande es {0} y es de {1}", max, nombre[x]);
    }
}


    //Console.WriteLine(notas.Max());




arreglos();