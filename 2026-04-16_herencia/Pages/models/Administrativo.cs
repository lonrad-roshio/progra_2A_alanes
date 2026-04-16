namespace ConsoleApp1;

public class Administrativo : Empleado
{
    public string Profesion { get; set; }

    public Administrativo(string nombre, double sueldo, String codigo, double horasExtra, string profesion) : base(nombre, sueldo, codigo, horasExtra)
    {
        Profesion = profesion;
    }

    public override double Calcular_Salario()
    {
        return base.Calcular_Salario() + (HorasExtra *0.10*Sueldo);
    }
}
