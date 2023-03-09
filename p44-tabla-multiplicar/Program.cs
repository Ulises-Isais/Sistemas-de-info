//IMPRIMIR LA TABLA DE MULTIPLICAR QUE EL USUARIO PIDA
int c, t, n;
Console.Clear();
System.Console.WriteLine("Cual tabla quieres: ");
t = int.Parse(Console.ReadLine());

System.Console.WriteLine("Hasta donde quieres: ");
n = int.Parse(Console.ReadLine());

c = 1;
while (c <= n)
{
    Console.WriteLine($"{t,3} * {c,3} = {t*c,4}");
    c++;
}
