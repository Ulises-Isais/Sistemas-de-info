// imprime pares de 1 a n e impares de n a 1 y sus sumas

int op,n;
int suma;
do
{
    suma=0;
    Console.Clear();
    System.Console.WriteLine("[1] numeros pares de 1 a n");
    System.Console.WriteLine("[2] numeros impares de n a 1");
    System.Console.WriteLine("[3] Salir...");
    System.Console.Write("Elige: ");
    op = int.Parse(Console.ReadLine());

    switch (op)
    {
        case 1:
        System.Console.WriteLine("\nImprimiendo numeros de 1 a n");
        System.Console.Write("Hasta donde: ");
        n = int.Parse(Console.ReadLine());
        for (int i = 2; i <= n; i+=2)
        {
            System.Console.Write($"{ i } ");
            suma += i; 
        }
        Console.WriteLine($"\nla suma de pares es: {suma} ");
        
            break;
        case 2:
        System.Console.WriteLine("\nImprimiendo numeros impares de n a 1");
        System.Console.Write("Desde donde: ");
        n = int.Parse(Console.ReadLine());
        n = (n %2==0 ? n-- :n);
        for (int i = n; i >= 1; i-=2)
        {
            System.Console.Write($"{ i } ");
            suma+=i;
        }
            Console.WriteLine($"\nla suma de los impares es: {suma} ");
            
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