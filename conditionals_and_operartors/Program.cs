﻿/*Conditionals*/
// Console.WriteLine("Ingrese un numero: ");
// int num = int.Parse(Console.ReadLine());

// if (num > 0) Console.WriteLine("Positivo");
// else if (num < 0) Console.WriteLine("Negativo");
// else Console.WriteLine("Es cero");
/*End Conditionals*/


/*Operators*/
Console.WriteLine("Ingrese el primer numero: ");
double a = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el segundo numero: ");
double b = double.Parse(Console.ReadLine());
const string Indeterminado = "Indeterminado";
Console.WriteLine($"Sumas: {a+b}, Resta: {a-b}, Multiplicacion: {a*b}, Division: {(b!=0 ? a/b : Indeterminado)}");
/*End Operators*/