
using System;
int renglones;
char resp;
do
{
    Console.Clear();
    Console.Write("Ingrese el número de renglones que desea imprimir: ");
        renglones = int.Parse(Console.ReadLine());

        for (int i = 1; i <= renglones; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write($"{j} ");
            }
            
            Console.WriteLine();
        }
            System.Console.Write("\nDeseas Continuar S/N: ");
            resp = char.ToUpper(Console.ReadLine()[0]);
} while (resp !='N');

