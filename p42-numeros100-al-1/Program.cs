//IMPRIME LOS NUMEROS DEL 100 AL 1
int c,n,p;
Console.Clear();
System.Console.Write("Hasta donde quieres llegar: ");

n = int.Parse(Console.ReadLine());
System.Console.WriteLine("Paso: ");
p = int.Parse(Console.ReadLine());
c = n;

while (c >= 1)
{
    Console.Write($"{c+" "}");
    c-=p;
    
}

System.Console.WriteLine("\nProceso terminado");