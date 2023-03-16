using System;
//Imprimir los numeros desde 1 hasta n
int n,p;
char resp;
do
{
    
Console.Clear();
    System.Console.WriteLine("Desde donde quieres empezar?");

    n = int.Parse(Console.ReadLine());
    System.Console.WriteLine("A que paso: ?");
    p = int.Parse(Console.ReadLine());

    for (int i = n; i >= 1 ; i-=p)
    {
        Console.Write($"{i} ");

    }
        System.Console.WriteLine("\nDeseas Continuar S/N:");
        resp = char.ToUpper(Console.ReadLine()[0]);
} while (resp !='N');
System.Console.WriteLine("\nProceso terminado ...");