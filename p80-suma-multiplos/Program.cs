int opcion, ini, fin, constante;
do
{
    System.Console.WriteLine("Selecciona una opción");
    System.Console.WriteLine("1. Sumar multiplos de 3");
    System.Console.WriteLine("2. Sumar multiplos de 4");
    System.Console.WriteLine("3. Salir");
    opcion = int.Parse(Console.ReadLine());
    switch (opcion)
    {
        case 1:
        System.Console.WriteLine("Ingrese el rango inicial:");
        ini = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Ingrese el rango final: ");
        fin = int.Parse(Console.ReadLine());
        Console.WriteLine($"La suma de los multiplos de 3 entre {ini} y {fin} es: {SumaMultiplos(ini,fin,3)}");
            break;
        case 2:
        System.Console.WriteLine("Ingrese el rango inicial:");
        ini = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Ingrese el rango final: ");
        fin = int.Parse(Console.ReadLine());
        Console.WriteLine($"La suma de los multiplos de 4 entre {ini} y {fin} es: {SumaMultiplos(ini,fin,4)}");
            break;
        case 3:
        System.Console.WriteLine("Saliendo del programa...");
            break;
        default:
         System.Console.WriteLine("Opción no valida.");
            break;
    }
    
    System.Console.WriteLine();
    
} while (opcion != 3);

int SumaMultiplos(int ini, int fin, int constante){
    int suma = 0; 
    for (int i = ini; i <= fin; i++)
    {
        suma += i;
    }
    return suma;
}