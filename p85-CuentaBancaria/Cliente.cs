public class Cliente
{
    public string Nombre {get; set;}
    public string Apellido {get; set;}
    public CuentaBancaria Cuenta {get; set;}

    public Cliente(string nombre, string apellido) => (Nombre,Apellido) = (nombre,apellido);

    public override string ToString() => $"{Nombre}, {Apellido}";
    
}