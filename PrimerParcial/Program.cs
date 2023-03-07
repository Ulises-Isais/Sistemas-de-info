//Primer Examen Parcial

void Menu(){
Console.Clear();
System.Console.WriteLine("Universidad Autonoma de Zacatecas ---------------------\n");
System.Console.WriteLine("Tipo de usuario: [A]Alumno $100, [T]Trabajador $200, [D]Docente $500");
System.Console.WriteLine("Tipo de paquete: [1] Solo conferencias $600, [2] Con eventos sociales $800, [3] Con kit de acceso $900");
System.Console.WriteLine("-------------------------------------------------------------------------------------\n");
}
char usuario, paquete;
float subtotal = 0, cantidad, descuento, total;
string usu, paq;
if (args.Length<3)
{
    Menu();
    return 1;
}

usuario = char.Parse(args[0].ToUpper());
if (usuario == 'A' )
{
    usu = "Alumno";
    subtotal += 100;
}else if (usuario == 'T'){

    usu = "Trabajador";
    subtotal += 200;

}else
{
    usu = "Docente";
    subtotal += 500;
}

// //Procesar el paquete 
 paquete = char.Parse(args[1].ToUpper());
if (paquete == '1')
{
    paq = "Solo Conferencias";
     subtotal+= 600;
}else if( paquete == '2'){
    
    paq = "Con Eventos Sociales";
    subtotal+= 800;
}else
{
    paq = "Con kit de acceso";
    subtotal+= 900;
}

// Cantidad
cantidad = float.Parse(args[2].ToUpper());
subtotal = subtotal * cantidad;

// Calcular descuento
if (subtotal > 5000 && usu == "Alumno")
{
    descuento = 0.20f;
}else if (subtotal > 5000 && usu == "Trabajador")
{
    descuento = 0.10f;
}else
{
    descuento = 0.05f;
}

total = subtotal - (subtotal * descuento);

Console.WriteLine($"Tu pedido fue: {cantidad}");
Console.WriteLine($"Tipo de usuario: {usu}");
Console.WriteLine($"Tipo de paquete: {paq}");
Console.WriteLine($"Precio normal: {subtotal:c}, descuento: {subtotal*descuento:c} ({descuento:p2}), Total con descuento: {total:c}  ");



return 0;