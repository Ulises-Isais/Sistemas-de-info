// Dada una cantidad en horas, calcular su equivalente en días, minutos y segundos, considerando que >
// • 1 día tiene 24 horas, 
// • 1 hora tiene 60 minutos, 
// • 1 minuto tiene 60 segundos
int horas, minutos, segundos, dias;
Console.Clear();
System.Console.WriteLine("Muestras las horas en minutos, segundos y dias");
System.Console.Write("Ingrese cantidad de horas: ");
horas = int.Parse(Console.ReadLine());
minutos = horas * 60;
dias = horas / 24;
segundos = horas * 3600;
System.Console.WriteLine($"Minutos: {minutos}");
System.Console.WriteLine($"Dias: {dias}");
System.Console.WriteLine($"Segundos: {segundos}");