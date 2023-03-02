using System;
// Administrarla venta de pizzas

void Menu(){
Console.Clear();
System.Console.WriteLine("Elige como deseas armar tu pedido de pizza:\n");
System.Console.WriteLine("Tamaño : [C]hica - $5 [M]ediana - $10 [G]rande - $15");
System.Console.WriteLine("Ingredientes: [E]xtra queso [C]hampiñoness [P]iña , unidos por un + - $5 por ingrediente");
System.Console.WriteLine("Cubierta : [D]elgada [G]ruesa");
System.Console.WriteLine("Donde : [A]qui [L]levar");

}
char tam,cub,don;
string[] ings;
float subtotal = 0, descuento, total, cantidad;
string tamaño, ingredientes = "",cubierta , donde, cliente;

if (args.Length<5) 
{
    Menu();
    return 1;
}

tam = char.Parse(args[0].ToUpper());
if (tam == 'C')
{
    tamaño = "Chica";
    subtotal+=5;
}else if (tam == 'M' )
{
    tamaño = "Mediana";
    subtotal+=10;
}else
{
    tamaño = "Grande";
    subtotal +=15;
}

//Procesar ingredientes
ings = args[1].Split("+");
foreach (string ing in ings)
{
    switch(Char.Parse(ing.ToUpper())){
        case 'E':
        ingredientes+="ExtraQueso ";
        break;
        case 'C':
        ingredientes+="Champiñones ";
        break;
        case 'P':
        ingredientes+="Piña ";
        break;
    }
    subtotal+=5;
}
//Cubierta
cub = char.Parse(args[ 2 ].ToUpper());
cubierta = (cub=='D' ? "Delgada" : "Gruesa");

//Procesar donde
don = char.Parse(args[ 3 ].ToUpper());
donde = (don == 'A' ? "Aqui" : "Llevar");

//Cantidad
cantidad = float.Parse(args[4]);
subtotal = subtotal * cantidad;

//Descuento
if (subtotal < 1000)
{
    descuento = 0.0f;
    cliente = "Platino";
}if (subtotal < 2000)
{
    descuento = 0.10f;
    cliente = "Plata";
}else
{
    descuento = 0.20f;
    cliente = "Oro";
}
total = subtotal - (subtotal * descuento);

Console.WriteLine($"Tamaño: {tamaño}");
Console.WriteLine($"Ingredientes: {ingredientes}");
Console.WriteLine($"Cubierta: {cubierta}");
Console.WriteLine($"Donde: {donde}");
Console.WriteLine($"Cantidad: {cantidad} $Subtotal: {subtotal:c}, eres cliente: {cliente}, descuento: {subtotal*descuento:c} ({descuento:p2}), Total con descuento: {total:c}");



return 0;