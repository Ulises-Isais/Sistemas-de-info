// Se desea calcular el volumen de un cilindro dado su radio y altura
double volumen, radio, altura;
Console.Clear();
System.Console.WriteLine("Ingresa el radio del cilindro: ");
radio = double.Parse(Console.ReadLine());
System.Console.WriteLine("Ingresa la altura del cilindro: ");
altura = double.Parse(Console.ReadLine());
volumen = Math.PI *(radio * radio) * altura;
System.Console.WriteLine($"El volumen del cilindro es: {volumen}");

