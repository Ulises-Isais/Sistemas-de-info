// Imprime la tabla de multiplicar hasta donde pida con funciones
void Tabla (int tabla, int n){
    Console.WriteLine($"tabla del {tabla}");
    for (int i = 1; i <= n; i++)
    {
        Console.WriteLine($"{tabla} x {i} = {tabla*i}");
    }
        System.Console.WriteLine();

}

Console.Clear();
System.Console.Write("Que tabla deseas: ");
int tabla = int.Parse(Console.ReadLine());
System.Console.Write("Hasta donde quieres llegar:");
int n = int.Parse(Console.ReadLine());

Tabla(tabla, n);
