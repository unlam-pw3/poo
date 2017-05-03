namespace Ejemplo.MVC._2.Dominio.Entidades
{
    public class Programador : Empleado, ICalcularSueldoBruto
    {
        public decimal ValorHora { get; }
        public decimal Incentivo { get; }
        public decimal HorasTrabajadas { get; }

        public Programador(string nombre, string apellido, decimal valorHora, decimal horasTrabajadas)
            : base(nombre, apellido)
        {
            Incentivo = 1500;
            ValorHora = valorHora;
            HorasTrabajadas = horasTrabajadas;
        }

        public decimal Calcular()
        {
            return Incentivo + ValorHora + HorasTrabajadas;
        }
    }
}