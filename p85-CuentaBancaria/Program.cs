//Control Bancario
System.Console.WriteLine("\nProbando clase CuentaBancaria");
CuentaBancaria cuenta1 = new CuentaBancaria(5000);
cuenta1.Deposita(10000);
Console.WriteLine($"El saldo es {cuenta1.Saldo}");
bool retiro = cuenta1.Retira(56);
if (retiro)
{
    Console.WriteLine($"Saldo retirado: {cuenta1.Saldo}");
    
}else
{
    Console.WriteLine("No se pudo retirar, saldo insuficiente");
    
}

System.Console.WriteLine("\nProbando clase Cliente");
Cliente cliente1 = new Cliente ("Uriel", "Garcia");
cliente1.Cuenta = cuenta1;
Console.WriteLine($"Cliente : {cliente1.ToString()}");
Console.WriteLine($"El Saldo es: {cliente1.Cuenta.Saldo}");
Cliente cliente2 = new Cliente ("Carlos","Castañeda");
cliente2.Cuenta =  new CuentaBancaria(100000000);
cliente2.Cuenta.Retira(5000);
Console.WriteLine($"Cliente : {cliente2.ToString()}");
Console.WriteLine($"El Saldo es: {cliente2.Cuenta.Saldo}");

System.Console.WriteLine("\nProbando clase Banco");
Banco mibanco = new Banco ("Banco Patito SA de CV","Arboledas 124");
mibanco.AgregarCliente(cliente1);
mibanco.AgregarCliente(cliente2);
Cliente cliente3 = new Cliente("Solo vino","Solo se fue");
cliente3.Cuenta = new CuentaBancaria(1001);
mibanco.AgregarCliente(cliente3);
mibanco.Clientes[0].Cuenta.Deposita(1000);
mibanco.Clientes[1].Cuenta.Retira(5000000);
mibanco.Clientes[2].Cuenta.Retira(234560);
System.Console.WriteLine("\nResumen del Banco \n");

Console.WriteLine($"Banco: {mibanco.ToString()}");

foreach (Cliente cl in mibanco.Clientes)
{
    Console.WriteLine($"Cliente {cl.ToString()}");
    Console.WriteLine($"Saldo {cl.Cuenta.Saldo}");

    
}




