using System;
char resp;
do
{
        Console.Clear();
        Console.Write("Ingrese el número de términos que desea imprimir: ");
        int num = int.Parse(Console.ReadLine());
        
        double sum = 0;
        for (int i = 1; i <= num; i++)
        {
            sum += 1.0 / i;
            Console.Write("1/{0}", i);
            
            if (i < num)
            {
                Console.Write(" + ");
            }
        }
        
        Console.WriteLine();
        Console.WriteLine("Suma: {0}", sum);
        System.Console.Write("\nDeseas Continuar S/N: ");
        resp = char.ToUpper(Console.ReadLine()[0]);
} while (resp != 'N');
