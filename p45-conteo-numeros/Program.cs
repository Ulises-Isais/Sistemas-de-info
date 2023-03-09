//Cuenta numeros: positivos, negativos, ceros y calucla la suma 
int n,c=0, s= 0;
int cp=0,cn=0,cz=0;
Console.ReadLine();
System.Console.WriteLine("Cuenta numeros: positivos, negativos, ceros y calucla la suma");

do
{
    System.Console.Write("Numero: ");
    n = int.Parse(Console.ReadLine());

    if (n != 999)
    {
        c++;
        s += n;
        if (n > 0)
        {
            cp++;
        }
        else if (n < 0)
        {
            cn--;
        }else
        {
            cz++;
        }
    }

} while ( n != 999);

System.Console.WriteLine("Fin de captura");
System.Console.WriteLine($"Numeros capturados {c} y su suma es {s}");
Console.WriteLine($"Positivos {cp}, Negativos {cn} , Ceros {cz}");
