using System;
int opcion;
do
{
    System.Console.WriteLine("Elija una opción:");
    System.Console.WriteLine("1. Convertir pulgadas a centimetros");
    System.Console.WriteLine("2. Convertir centimetros a pulgadas");
    System.Console.WriteLine("3. Salir");
    opcion = int.Parse(Console.ReadLine());
    switch (opcion)
    {
        case 1:
        System.Console.WriteLine("Ingrese la cantidad de pulgadas");
        double pulgadas = double.Parse(Console.ReadLine());
        double centimetros = PulgadasAcentimetros(pulgadas);
        System.Console.WriteLine($"{pulgadas} pulgadas son {centimetros} centimetros");
            break;
        case 2:
        System.Console.WriteLine("Ingrese la cantidad de metros");
        double metros = double.Parse(Console.ReadLine());
        double pies = MetrosAPies(metros);
        System.Console.WriteLine($"{metros} metros son {pies} pies");
            break;
        case 3:
        System.Console.WriteLine("Saliendo del programa...");
            break;
        default:
        System.Console.WriteLine("Opción no valida ");
            break;
    }
    
} while (opcion != 3);

double PulgadasAcentimetros(double pulgadas){
    return pulgadas * 2.54;
}

double MetrosAPies(double metros){
    return metros * 3.281;
}