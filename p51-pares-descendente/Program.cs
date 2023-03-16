using System;
// imprime los numeros pares de 100 a n, calcula su suma, y su primedio, el proceso se repite
int n;
int count, i = 100;
int sum = 0;
char resp;
do
{
Console.Clear();
System.Console.WriteLine(" Imprime los numeros pares de 100 a n, calcula su suma, y su primedio, el proceso se repite \n");
System.Console.Write("Hasta donde deseas los pares ?:");
n = int.Parse(Console.ReadLine());

count = 0;
    System.Console.WriteLine($"Numeros pares entre 100 y {n}");
    while ( i >= n )
    {
        if (i % 2 == 0)
        {
            System.Console.Write($"{i} ");
            sum+= i;
            count++;
        }
        i-=2;
    }
    float promedio = (sum / count);
    
    Console.WriteLine($"\nLa suma de los numeros pares es: {sum}");
    Console.WriteLine($"El promedio de los numeros pares es: {promedio}");
    
    System.Console.Write("\nDeseas continuar (S/N): ");
    resp = char.ToUpper(Console.ReadLine()[0]);
} while (resp !='N');
System.Console.WriteLine("Fin del programa");