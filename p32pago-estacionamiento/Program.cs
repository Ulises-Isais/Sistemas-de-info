using System;
//Administra el pago por estacionamiento de acuerdo a la zona

int op;
float tasa, pago, impuesto, total;
Console.Clear();
System.Console.Write("Elige una opcion: \n");
System.Console.WriteLine("1- Estacionamiento Tacuba 3%");
System.Console.WriteLine("2- Estacionamiento Portales 5%");
System.Console.WriteLine("3- Estacionamiento Conquistadores 10%");
System.Console.WriteLine("4- Estacionamiento Pajaros caidos 15%");
op = int.Parse(Console.ReadLine());
System.Console.WriteLine("Pago efectuado: ");
pago = float.Parse(Console.ReadLine());
tasa = 0.0f;
switch (op)
{
    case 1: 
    tasa = 0.03f;
        break;
    case 2:
    tasa = 0.5f;

        break;
    case 3:
    tasa = 0.10f;

        break;
    case 4:
    tasa = 0.15f;

        break;
    default:
        break;
}
impuesto = pago * tasa;
total = pago + impuesto;
String salida = string.Format($"Elegiste el estacionamiento {op}\n" + 
            $"Pagaste {pago} por el tiempo de uso\n" +
            $"Corresponde el impuesto de {impuesto:n2}\n" +
            $"El pago total es de {total:n2}");

System.Console.WriteLine(salida);