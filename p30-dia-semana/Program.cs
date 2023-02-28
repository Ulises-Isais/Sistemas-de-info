//Dado un numero entre 1 y 7 imprime el dia de la semana

int dia;

Console.Clear();
Console.Write("Dame el dia con numero : ");
dia = int.Parse(Console.ReadLine());

switch (dia)
{
    case 1:
    System.Console.WriteLine("Lunes");
        break;
    case 2:
    System.Console.WriteLine("Martes");

        break;
    case 3:
    System.Console.WriteLine("Miercoles");

        break;
    case 4:
    System.Console.WriteLine("Jueves");

        break;
    case 5:
    System.Console.WriteLine("Viernes");

        break;
    case 6:
    System.Console.WriteLine("Sabado");

        break;
    case 7:
    System.Console.WriteLine("Domingo");

        break;    
    default:
    System.Console.WriteLine("En que dia vives!!! TONTO");
        break;
}


Console.WriteLine("\nProceso terminado....");
