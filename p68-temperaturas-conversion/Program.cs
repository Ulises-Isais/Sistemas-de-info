//CONVERSION DE TEMPERATURA USANDO FUNCIONES
float Farenheit(float t){
    return (t*9/5) +32;
}

float celsius(float t){
    return (t-32)*5/9;
}

//Programa principal
int op;
float temp, res;
Console.Clear();
System.Console.WriteLine("CONVERSION DE TEMPERATURA USANDO FUNCIONES\n");
System.Console.WriteLine("[1] Farenheit \n[2] Centigrados");
System.Console.Write("Elige");
op = int.Parse(Console.ReadLine());

switch (op)
{
    case 1:
    System.Console.Write("Dame la temperatura en celsius: ");
    temp = float.Parse(Console.ReadLine());
    res = Farenheit(temp);
    Console.WriteLine($"\n{temp}°C equivale a {res}°F");
    
        break;
    case 2:
    System.Console.Write("Dame la temperatura en farhenheit:");
    temp = float.Parse(Console.ReadLine());
    res = Farenheit(temp);
    Console.WriteLine($"\n{temp}°F equivale a {res}°C");
        break;
    default:
        break;
}
