//Segundo examen parcial
const int MAX = 100;
double [] Calif = new double[MAX];
double suma = 0, promedio = 0;
int op;
double comp = 0;
int n = 0;
double nb, contador;
do
{
    op = menu();
    switch (op)
    {
        case 1:
        System.Console.WriteLine("Cuantas calificaciones vas a ingresar?");
            n = int.Parse(Console.ReadLine());
            if (n > MAX)
            {
                System.Console.WriteLine("Excediste el limite");
            }else
            {
                for (int i = 0; i < n; i++)
                {
                
                    do
                    {
                   
                        Console.Write($"Calificación [{i+1}]: ");
                        Calif[i] = double.Parse(Console.ReadLine());
                    } 
                 while (Calif[i] < 0 || Calif[i] > 100);
                }
            }   
            break;
        case 2: Mostrar(Calif, n);
            break;
        case 3:
        suma = Promedio(Calif, n);
        promedio = suma / n;
        Console.WriteLine($"El promedio es: {promedio:f2}"); 
            break;
        case 4:
        Complemento(Calif,n);
            break;
        case 5:
            System.Console.WriteLine("\nQue elemento buscas?");
             nb = double.Parse(Console.ReadLine());
             contador = Buscar(Calif, nb, n);
            if (contador == 0) 
            System.Console.WriteLine("Elemento NO encontrado");
            else System.Console.WriteLine($"Elemento encontrado: {contador} veces");
            break;
        default:
            break;
    }
    System.Console.WriteLine("Presione cualquier tecla para continuar...");
    Console.ReadLine();
        
} while (op != 6);
int menu(){
    Console.Clear();
    System.Console.WriteLine("Leer Calificaciones                           [1]");
    System.Console.WriteLine("Mostrar Calificaciones                        [2]");
    System.Console.WriteLine("Calcular promedio y mayores al promedio       [3]");
    System.Console.WriteLine("Complemento a 100                             [4]");
    System.Console.WriteLine("Buscar Calificación                           [5]");
    System.Console.WriteLine("Salir                                         [6]");
    System.Console.WriteLine("Elige una Opción");

    int op = int.Parse(Console.ReadLine());
    return op;
}

void Mostrar(double[] a, int n){
    for (int i = 0; i < n; i++)
    {
        System.Console.WriteLine($"Calificación [{i+1}]: {a[i]}");
    }
}

double Promedio(double [] a, int n){
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

void Complemento(double[] a, int n){
    for (int i = 0; i < n; i++)
        System.Console.WriteLine($"{100-a[i]}  ");
}

double Buscar(double[] a, double nb, int n){
    int contador = 0;
    for (int i = 0; i < n; i++)
    if (a[i] == nb)
        contador++;

    return contador;
    
}