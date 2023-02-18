using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Que edad tienes? ");
        byte edad = byte.Parse(Console.ReadLine());
        Console.WriteLine("No pareces tener {0} años.", edad);
    }
        }