// Verifica si el numero es positivo, negativo o cero
int n;
Console.Write("Dame un numero pls : ");
n = int.Parse(Console.ReadLine());

Console.Clear();
if (n > 0)  System.Console.WriteLine("El numero es positivo ..");

if (n<0) System.Console.WriteLine("El numero es negativo..");   

if (n == 0)  System.Console.WriteLine("El numero es 0..");


System.Console.WriteLine("Fin de programa");