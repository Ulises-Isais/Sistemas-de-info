//suma un rango de valores usando una funcion

float Rango(float i, float f){
    float s=0;
    for (float j = i; j <= f; j++)
    {
        s +=j;
    }
        return s;

}


float ini, fin, res;

Console.Clear();
do
{
    System.Console.WriteLine("Inicio: "); ini=float.Parse(Console.ReadLine());
    System.Console.WriteLine("Fin: "); fin=float.Parse(Console.ReadLine());

} while (ini > fin);

res = Rango(ini,fin);

Console.WriteLine($"\n la suma del rango es: {res:f2}");
