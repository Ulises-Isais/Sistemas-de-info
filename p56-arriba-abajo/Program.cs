//imprime numeros de 1 a n o de n a 1 segun lo decida el usuario

int op,n;
do
{
    
    Console.Clear();
    System.Console.WriteLine("[1] numeros de 1 a n");
    System.Console.WriteLine("[2] numeros de n a 1");
    System.Console.WriteLine("[3] Salir...");
    System.Console.Write("Elige: ");
    op = int.Parse(Console.ReadLine());

    switch (op)
    {
        case 1:
        System.Console.WriteLine("\nImprimiendo numeros de 1 a n");
        System.Console.Write("Hasta donde: ");
        n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            System.Console.Write($"{ i } ");
    
        }
            break;
        case 2:
        System.Console.WriteLine("\nImprimiendo numeros de n a 1");
        System.Console.Write("Desde donde: ");
        n = int.Parse(Console.ReadLine());
        for (int i = n; i >= 1; i--)
        {
            System.Console.Write($"{ i } ");
    
        }
            break;
        case 3: 
        System.Console.WriteLine("Gracias por participar jejeje!!");
            break;
        default:
        System.Console.WriteLine("\n Opción invalida!");
        break;
    }
System.Console.WriteLine("\nPresiona cualquier tecla para continuar");Console.ReadLine();


} while (op != 3);

System.Console.WriteLine("\nPRoceso terminado...");