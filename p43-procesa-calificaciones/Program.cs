//Procesa n calificaciones, calcula la suma y el promedio
int n,c;
float calif, suma = 0, promedio = 0;
Console.Clear();
System.Console.WriteLine("Procesa n calificaciones, calcula la suma y el promedio");
System.Console.WriteLine("Cuantas calificaciones: ");
n = int.Parse(Console.ReadLine());

c = 1;
while ( c <= n)
{
    System.Console.Write($"Calificación {c++}: ?");
    calif = float.Parse(Console.ReadLine());
    suma += calif;
}
promedio = suma / n;

Console.WriteLine($"Promedio final: {promedio:f2}");
