//Convierte un numero entero de entre 1 y 10 a numero romano

int num;
Console.Clear();
System.Console.WriteLine("Dame un numero entero: ");
num = int.Parse(Console.ReadLine());
switch (num)
{
    case 1:
    System.Console.WriteLine("I");
        break;
    case 2:
    System.Console.WriteLine("II");
        break;
    case 3:
    System.Console.WriteLine("III");
        break;
    case 4:
    System.Console.WriteLine("IV");
        break;
    case 5:
    System.Console.WriteLine("V");
        break;
    case 6:
    System.Console.WriteLine("VI");
        break;
    case 7:
    System.Console.WriteLine("VII");
        break;
    case 8:
    System.Console.WriteLine("VIII");
        break;
    case 9:
    System.Console.WriteLine("IX");
        break;
    case 10:
    System.Console.WriteLine("X");
        break;
    default:
    System.Console.WriteLine("Numero invalido...");
        break;
}
 System.Console.WriteLine("\n Proceso terminado...");