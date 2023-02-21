//Convertir temperatura de grados celcius a farenheit y viceversa.
char op;
float temp, res;

Console.Clear();
System.Console.WriteLine("Convertir grados celcius a ferenheit y viceversa\n");
System.Console.WriteLine("[F]arenheit");
System.Console.WriteLine("[C]entigrados");
Console.Write("Elige una opcion : "); 
op = char.ToUpper( Console.ReadLine()[0]);

if (op == 'F')
{
    System.Console.WriteLine("Convirtiendo a Farenheit");
    System.Console.WriteLine("Ingresa los grados Celsius"); 
    temp = float.Parse(Console.ReadLine());
    res = ( temp * 9 / 5 ) + 32;
    System.Console.WriteLine($"La temperatura {temp} celsius equivale en Farenheit a = {res}");  
}
else
{
    System.Console.WriteLine("Convirtiendo a Celsius");
    System.Console.WriteLine("Ingresa los grados Farenheit"); 
    temp = float.Parse(Console.ReadLine());
    res = ( temp - 32 ) * 9 / 5;
    System.Console.WriteLine($"La temperatura {temp} Farenheit equivale en Celsius a = {res}");  
}

System.Console.WriteLine("\nGracias por usar el programa, Saludos jeejje");

