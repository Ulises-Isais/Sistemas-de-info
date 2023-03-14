using System;
// imprime los numeros pares de 2 a n, calcula su suma, el proceso se repite
int c, n, s;
char resp;

do
{
Console.Clear();
System.Console.WriteLine(" imprime los numeros pares de 2 a n, calcula su suma, el proceso se repite \n");
System.Console.Write("Hasta donde deseas los pares ?:");
n = int.Parse(Console.ReadLine());

c = 2;
s = 0;

while (c <= n)
{
    Console.Write($"{c}");
    s += c;
    c += 2;
}
Console.WriteLine($"\n la suma de los numeros pares de 2 a {n} es {s}");

    System.Console.Write("\nDeseas continuar (S/N): ");
    resp = char.ToUpper(Console.ReadLine()[0]);
} while (resp!= 'N');

System.Console.WriteLine("\n Proceso terminado");