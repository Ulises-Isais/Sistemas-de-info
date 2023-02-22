
// Calcular el 3er angulo de un triangulo dados los dos primeros angulos del mismo
double angulo1, angulo2, angulo3;
Console.Clear();
System.Console.WriteLine("Ingresa el primer angulo: ");
angulo1 = Double.Parse(Console.ReadLine());
System.Console.WriteLine("Ingresa el segundo angulo: ");
angulo2 = Double.Parse(Console.ReadLine());
angulo3 = 180 - (angulo1+angulo2);
System.Console.WriteLine($"El valor del 3er angulo es: {angulo3:f2}");
System.Console.WriteLine();