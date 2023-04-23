System.Console.WriteLine("Ingrese 4 numeros enteros:");
int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
int num3 = int.Parse(Console.ReadLine());
int num4 = int.Parse(Console.ReadLine());

int menor = EncontrarMenor(num1,num2,num3,num4);
Console.WriteLine($"El menor de los numeros es: {menor}");

int EncontrarMenor(int a, int b, int c, int d){
    int menor = a;
    if (b < menor )
    menor = b;
    if (c < menor)
    menor = c;
    if (d < menor)
    menor = d;

    return menor;
}