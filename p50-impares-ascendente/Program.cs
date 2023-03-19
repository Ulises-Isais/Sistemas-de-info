using System;
// imprime los numeros impares de 1 a n, calcula su suma, el proceso se repite
int n;
int count, i = 1;
int sum = 0;
char resp;
do
{
Console.Clear();
System.Console.WriteLine(" imprime los numeros impares de 1 a n, calcula su suma, el proceso se repite \n");
System.Console.Write("Hasta donde deseas los impares ?:");
n = int.Parse(Console.ReadLine());

count = 0;
    System.Console.WriteLine($"Numeros impares entre 1 y {n}");
    while ( i <= n )
    {
        if (i % 2 == 1)
        {
            System.Console.Write($"{i} ");
            sum+= i;
            count++;
        }
        i++;
    }
    double promedio = (sum / count);
    
    Console.WriteLine($"\nLa suma de los numeros impares es: {sum}");
    Console.WriteLine($"El promedio de los numeros impares es: {promedio}");
    i = 0;
    count = 0;
    sum = 0;
    System.Console.Write("\nDeseas continuar (S/N): ");
    resp = char.ToUpper(Console.ReadLine()[0]);
} while (resp !='N');

System.Console.WriteLine("Fin del programa");