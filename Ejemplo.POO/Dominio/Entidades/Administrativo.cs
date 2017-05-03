namespace Ejemplo.MVC._2.Dominio.Entidades
{
    public class Administrativo : Empleado, ICalcularSueldoBruto
    {
        public decimal Sueldo { get; }

        public Administrativo(string nombre, string apellido)
            : base(nombre, apellido)
        {
            Sueldo = 15000;
        }

        public decimal Calcular()
        {
            return Sueldo;
        }
    }
}