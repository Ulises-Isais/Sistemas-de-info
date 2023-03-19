// Genera una tabla de conversion de centigrados a fahrenheit 

float fahrenheit;
float inicio, fin, c;
char resp;

do
{
    Console.Clear();
    System.Console.WriteLine("Genera una tabla de conversion de centigrados a fahrenheit en un rango de valores\n");
    do
    {
        System.Console.WriteLine("Ingrese la temperatura inicial en centigrados");
        inicio = float.Parse(Console.ReadLine());
        System.Console.WriteLine("Ingrese la temperatura final en centigrados");
        fin = float.Parse(Console.ReadLine());
        if (fin < inicio)
        {
            System.Console.WriteLine("Error: la temperatura final no puede ser menor a la inicial");
        }
    } while (fin < inicio);

    c = inicio;
    System.Console.WriteLine(new string ('-',30));
    Console.WriteLine($"Centigrados\tFahrenheit");
    System.Console.WriteLine(new string ('-',30));
    while (c <= fin)
    {
        fahrenheit = (c * 9 / 5) + 32;
        Console.WriteLine($"{c:f2}°C\t{fahrenheit:f1}°F");
        c++; 
    }
    System.Console.WriteLine(new string ('-',30));
    System.Console.Write("\nDeseas continuar (S/N): ");
    resp = char.ToUpper(Console.ReadLine()[0]);
} while (resp != 'N');
System.Console.WriteLine("Fin de programa...!!!");