System.Console.WriteLine("Ingrese un numero entre 1 y 7:");
int num = int.Parse(Console.ReadLine());

string Dia = ObtenerDia(num);

System.Console.WriteLine($"El dia de la semana correspondiente es: {Dia}");

string ObtenerDia(int num){
    string Dia = "";

    switch (num)
    {
        case 1:
        Dia = "Lunes";
            break;
        
        case 2:
        Dia = "Martes";
            break;
        
        case 3:
        Dia = "Miercoles";
            break;
        
        case 4:
        Dia = "Jueves";
            break;
        
        case 5:
        Dia = "Viernes";
            break;

        case 6:
        Dia = "Sabado";
            break;

        case 7:
        Dia = "Domingo";
            break;
        
        default:
            break;
    }
    return Dia;
}