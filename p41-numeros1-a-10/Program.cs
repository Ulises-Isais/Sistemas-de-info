//IMPRIME LOS NUMEROS DEL 1 AL 100
int c = 0,n,p;
Console.Clear();
System.Console.Write("Hasta donde quieres llegar: ");

n = int.Parse(Console.ReadLine());
System.Console.WriteLine("Paso: ");
p = int.Parse(Console.ReadLine());
while (c <= n)
{
    Console.Write($"{c+" "}");
    c+=p;
    
}

System.Console.WriteLine("\nProceso terminado");