//Dada una cantidad en pesos y la cotización del dólar, se desea obtener el equivalente en dólares
double pesos, dolares, tipoCambio;
char op;
Console.Clear();
System.Console.Write("Elige a que moneda deseas convertir:\n");
System.Console.WriteLine("[1]Pesos\n[2]Dolares");
op = char.ToUpper(Console.ReadLine()[0]);

if (op == '1')
{   
    System.Console.WriteLine("Convirtiendo de Dolares a Pesos\n");
    System.Console.Write("Ingresa el valor de pesos: ");
    pesos = double.Parse(Console.ReadLine());
    System.Console.Write("Ingresa el valor del tipo de cambio: ");
    tipoCambio = double.Parse(Console.ReadLine());
    dolares = pesos / tipoCambio;
    System.Console.WriteLine($"Convertido!! :{dolares:f2}");
    
}else
{
    System.Console.WriteLine("Convirtiendo de Pesos a Dolares\n");
    System.Console.Write("Ingresa el valor de Dolares: ");
    dolares = double.Parse(Console.ReadLine());
    System.Console.Write("Ingresa el valor del tipo de cambio: ");
    tipoCambio = double.Parse(Console.ReadLine());
    pesos = dolares * tipoCambio;
    System.Console.WriteLine($"Convertido!!: {pesos:f2}");
    
}

