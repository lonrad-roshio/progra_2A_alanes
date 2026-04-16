namespace ConsoleApp1;

public class Operario : Empleado
{
    public string Especialidad { get; set; }

    public Operario(string nombre, double sueldo, String codigo, double horasExtra, string especialidad) : base(nombre, sueldo, codigo, horasExtra)
    {
        Especialidad = especialidad;
    }

    public override double Calcular_Salario()
    {
        return base.Calcular_Salario() + (HorasExtra * 0.15 * Sueldo);
    }

}
