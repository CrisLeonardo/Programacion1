

using Ejercicio4_06_05.Interface;

IAlumno pic = new IAlumno();

Console.WriteLine("Hola Cual es tu nombre: ");
string NameA = Console.ReadLine();
Console.WriteLine("Hola dime tu Nombre: ");
int Edad = int.Parse(Console.ReadLine());

pic.CumplirAnios();
pic.Saludar();
