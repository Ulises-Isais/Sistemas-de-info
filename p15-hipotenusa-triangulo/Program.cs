
//Calcular hipotenusa de un triangulo
double hipotenusa, Lado1, Lado2;
Console.Clear();
Console.Write("Ingresa el valor del lado 1: ");
Lado1 = Double.Parse(Console.ReadLine());
Console.Write("Ingresa el valor del lado 2: ");
Lado2 = Double.Parse(Console.ReadLine());
hipotenusa = Math.Sqrt(Lado1 * Lado1 + Lado2 * Lado2);
Console.WriteLine($"Valor de la hipotenusa: {hipotenusa:f5}");
