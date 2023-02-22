// Convertir los grados fahrenheit a grados celsius
float fahrenheit, celsius;
Console.Clear();
System.Console.WriteLine("Ingrese los grados Fahrenheit a convertir: ");
fahrenheit = float.Parse(Console.ReadLine());
celsius = (fahrenheit - 32) * 5/9; 
System.Console.WriteLine($"La conversion a Celsius: {celsius:f5}");
