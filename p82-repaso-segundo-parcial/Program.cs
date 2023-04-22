const int MAX = 100;
// double[] Nums = {10.5,6.8, 10.22, 14.33, 22.1};
double [] Nums = new double[MAX];
double suma = 0, promedio = 0;;
int op;
int n = 0;
double nb,pos;
do
{
    op = menu();
    switch (op)
    {
        case 1:
        System.Console.WriteLine("Cuantos elementos deseas?");
        n = int.Parse(Console.ReadLine());
        if (n > MAX)
        {
            System.Console.WriteLine("Excediste el limite");
        }else
        {
            for (int i = 0; i < n; i++)
            {
                System.Console.Write($"Elemento [{i+1}]");
                Nums[i] = double.Parse(Console.ReadLine());
                
            }
        }
        break;
        case 2: Mostrar(Nums, n);
            break;
        case 3:
        suma = Sumar(Nums, n);
        promedio = suma / Nums.Length;
        Console.Write($"\nLa suma es: {suma}");
        System.Console.WriteLine($"\n El promedio es: {promedio:f2}");
            break;
        case 4: 
            System.Console.WriteLine($"\nEl mayor es: {Mayor(Nums, n)}");
            System.Console.WriteLine($"\nEl menor es: {Menor(Nums, n)}");
            break;
        case 5:
        System.Console.WriteLine("\nQue elemento buscas?");
        nb = double.Parse(Console.ReadLine());
        pos = Buscar(Nums, nb, n);
        if (pos == -1) 
        System.Console.WriteLine("Elemento NO encontrado");
        else System.Console.WriteLine($"Encontrado en la posición {pos}");
        break;
        default:
            break;
    }
    
    System.Console.WriteLine("\nPresione cualquier tecla para continuar..");
    Console.ReadLine();
} while (op!=6);

int menu(){
    Console.Clear();
    System.Console.WriteLine("Leer elementos en el arreglo                  [1]");
    System.Console.WriteLine("Mostrar elementos en el arreglo               [2]");
    System.Console.WriteLine("Calcular y mostrar la suma y promedio         [3]");
    System.Console.WriteLine("Mayor y Menor del arreglo                     [4]");
    System.Console.WriteLine("Buscar elemento  en el arreglo                [5]");
    System.Console.WriteLine("Salir                                         [6]");
    System.Console.WriteLine("Elige una Opción");

    int op = int.Parse(Console.ReadLine());
    return op;
}

void Mostrar(double[] a, int n){
    for (int i = 0; i < n; i++)
    {
        System.Console.WriteLine($"{a[i]}");
    }
}

double Sumar(double[] a, int n){
    double suma = 0;
    for (int i = 0; i < n; i++)
        suma = suma + a[i];
        return suma;

}

double Mayor(double[] a, int n){
    double may = a[0];
    for (int i = 0; i < n; i++)
        if (a[i] > may)
            may = a[i];
        
    return may;
}

double Menor(double[] a, int n){
    double men = a[0];
    for (int i = 0; i < n; i++)
        if (a[i] < men)
            men = a[i];
        
    return men;
}

double Buscar(double[] a, double nb, int n){
    int pos = 1;
    for (int i = 0; i < n; i++)
    if (a[i] == nb)
        pos = i;

    return pos;
    
}