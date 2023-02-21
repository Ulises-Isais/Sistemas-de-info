//Calcular la paga de un trabajador

int hora, extra;
float paga, total;

Console.Clear();
System.Console.WriteLine("Calculando la paga de un trabajador\n");
System.Console.WriteLine("Dame las horas trabajadas"); hora=int.Parse(Console.ReadLine());
System.Console.WriteLine("Dame la paga"); paga=float.Parse(Console.ReadLine());

if (hora > 40)
{
    extra =  hora - 40;
    total = (40*paga) + (extra * paga * 2);
    System.Console.WriteLine($"\nHoras extra : {extra}");
    System.Console.WriteLine($"\nLa paga es : {total:n2}");
}
else
{
    total = hora * paga;
    System.Console.WriteLine($"\nPago Total : {total:f2}");
}
