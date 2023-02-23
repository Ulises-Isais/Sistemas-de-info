// Muestra el tipo de angulo según los grados 
Console.Clear(); 
Console.WriteLine("Muestra el tipo de angulo (0°..360°)\n");
Console.Write("Dame un angulo entre 0 y 360 : ");
int angulo = int.Parse(Console.ReadLine());

if (angulo<0 || angulo>360 )
{
    System.Console.WriteLine("Angulo invalido :o :( )");
}else
{
    if(angulo==0)System.Console.WriteLine("El angulo es nulo");
    if(angulo>0 && angulo<90) 
    Console.WriteLine("\nEs agudo");
    if(angulo==90) 
    Console.WriteLine("\nEs recto");
    if(angulo>90 && angulo<180) 
    Console.WriteLine("\nEs obtuso");
    if(angulo==180) 
    Console.WriteLine("\nEs llano");
    if(angulo>180 && angulo<360) 
    Console.WriteLine("\nEs concavo");
    if(angulo==360) 
    Console.WriteLine("\nEs completo");
    
}
