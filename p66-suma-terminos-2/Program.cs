using System;
char resp;
do
{
    
        Console.Write("Ingrese el número de términos que desea imprimir: ");
        int num = int.Parse(Console.ReadLine());
        
        int term = 1;
        int sum = 0;
        for (int i = 1; i <= num; i++)
        {
            Console.Write(term);
            sum += term;
            term = term * 10 + 1;
            
            if (i < num)
            {
                Console.Write(" + ");
            }
        }
        
        Console.WriteLine();
        Console.WriteLine("Suma: {0}", sum);
        System.Console.Write("\nDeseas Continuar S/N: ");
        resp = char.ToUpper(Console.ReadLine()[0]);
} while (resp !='N');