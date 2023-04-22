using System.Runtime.Intrinsics.X86;
// calcula el promedio de tres numeros usando una funcion 

float Promedio (float n1, float n2, float n3){
    float suma=0;
    suma = n1 + n2 + n3;
    return suma / 3;
}

string [] nums;
float n1, n2, n3,prom;

Console.Clear();
System.Console.WriteLine("Dame tres numeros separados por espacio");
nums = Console.ReadLine().Split();
n1 = float.Parse(nums[0]); 
n2 = float.Parse(nums[1]); 
n3 = float.Parse(nums[2]); 
prom = Promedio(n1,n2,n3);
Console.WriteLine($"El promedio es {prom:f2}");

