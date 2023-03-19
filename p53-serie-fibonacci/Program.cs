//Serie de fibonacci
int n,a = 0,b = 1,i = 0;
char resp;
int temp;
do
{
    Console.Clear();
    System.Console.WriteLine("Ingrese el numero de terminos de la serie de fibonacci");
    n = int.Parse(Console.ReadLine());
    while (i < n)
    {
        Console.Write($"{a} ");
        temp = a;
        a = b;
        b = temp + b;
        i++;
        
    }
    a = 0;
    b = 1;
    i = 0;
    
    System.Console.Write("\nDeseas continuar (S/N): ");
    resp = char.ToUpper(Console.ReadLine()[0]);
} while (resp != 'N');