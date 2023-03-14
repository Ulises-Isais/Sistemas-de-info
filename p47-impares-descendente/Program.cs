using System;
// imprime los numeros pares de 2 a n, calcula su suma, el proceso se repite
int c, n, s;
char resp;

do
{
Console.Clear();
System.Console.WriteLine(" imprime los numeros impares de n a 1, calcula su suma, el proceso se repite \n");
System.Console.Write("Desde donde deseas los impares ?:");
n = int.Parse(Console.ReadLine());

c = ( n%2==0 ? --n: n);
s = 0;

while (c >= 1)
{
    Console.Write($"{c} ");
    s += c;
    c -= 2;
}
Console.WriteLine($"\n la suma de los numeros impares desde {n} a 1 es {s}");

    System.Console.Write("\nDeseas continuar (S/N): ");
    resp = char.ToUpper(Console.ReadLine()[0]);
} while (resp!= 'N');

System.Console.WriteLine("\n Proceso terminado");