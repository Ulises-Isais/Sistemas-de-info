// Calcula la suma y el promedio de n numeros
    
int n;
float sum, prom, num;
char resp;
do
{
    sum = 0;
Console.Clear();
System.Console.WriteLine("Cuantos numeros :");
n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    Console.WriteLine($"Calificacion {i}: ");
    num = float.Parse(Console.ReadLine());
    sum+=num;
}

prom = sum/n;
Console.WriteLine($"La suma es {sum} \nel promedio es {prom}");

  System.Console.WriteLine("\nDeseas Continuar S/N:");
        resp = char.ToUpper(Console.ReadLine()[0]);
} while (resp != 'N');
System.Console.WriteLine("\nProceso terminado ...");