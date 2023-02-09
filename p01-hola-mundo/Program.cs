// Programa que envia un saludo en pantalla
string amigo = "Leo";
string hermano = "Fatima";
Console.WriteLine(amigo);
amigo="Alfonso";
Console.WriteLine("Hola "+amigo);
Console.WriteLine($"Hola {amigo} bienvenido a C#");
Console.WriteLine($"\nHola {amigo} mi hermano es {hermano}\n");
Console.WriteLine($"Nombres con mayusculas:");
Console.WriteLine($"{amigo.ToUpper()} {hermano.ToUpper()}");