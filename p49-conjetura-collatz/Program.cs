// Imprime la conjetura de Collatz para un numero entero positivo

long n ;
char resp;
do {
    do
    {
        System.Console.WriteLine("Entero positivo: ");
        n = long.Parse(Console.ReadLine());
    } while (n<0);

    while (n != 1)
    {
        Console.Write($"{n} ");
        if (n%2==0)
        {
            n = n/2;
        }else
        {
            n = n * 3 + 1;
        }

    }
    Console.WriteLine($"{n}");
    System.Console.Write("\nDeseas continuar (S/N): ");
    resp = char.ToUpper(Console.ReadLine()[0]);

} while (resp!= 'N');

System.Console.WriteLine("\n Proceso terminado");