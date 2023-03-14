// Genera una tabla de conversion de peso a dolar en un rango de valores

float tc = 18.64f, te = 19.95f;
float ini, fin, p;
char resp;
do{
    Console.Clear();
    System.Console.WriteLine("Genera una tabla de conversion de peso a dolar en un rango de valores\n");

    do
    {
        System.Console.Write("Inicio: ");    
        ini = float.Parse(Console.ReadLine());
        System.Console.Write("Final: ");
        fin = float.Parse(Console.ReadLine());

    } while (fin < ini);

    p = ini;
    System.Console.WriteLine(new string ('-',20));
    Console.WriteLine($"Peso\tDolar\tEuro");
    System.Console.WriteLine(new string ('-',20));

    while (p <= fin)
    {
        Console.WriteLine($"{p:n2}\t{p/tc:f2}\t{p/te:f2}");
        p+=1;
    }
    System.Console.WriteLine(new string ('-',20));
    System.Console.Write("\nDeseas continuar (S/N): ");
    resp = char.ToUpper(Console.ReadLine()[0]);

} while (resp!= 'N');

System.Console.WriteLine("\n Proceso terminado");
