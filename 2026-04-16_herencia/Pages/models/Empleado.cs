namespace ConsoleApp1;

public class Empleado
{
    public string Nombre { get; set; }
    public double Sueldo { get; set; }
    public String Codigo { get; set; }
    public double HorasExtra { get; set; }
    public Empleado(string nombre, double sueldo, String codigo, double horasExtra)
    {
        Nombre = nombre;
        Sueldo = sueldo;
        Codigo = codigo;
        HorasExtra = horasExtra;
    }
    public bool Es_Codigo_valido(string codigo)
    {
        for(int i = 0; i < codigo.Length; i++)
        {
            if (!char.IsDigit(codigo[i]))
            {
                return false;
            }
        }
        return true;
    }
    public virtual double Calcular_Salario()
    {
        return Sueldo;
    }
}
