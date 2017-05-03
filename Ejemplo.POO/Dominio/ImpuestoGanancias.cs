namespace Ejemplo.MVC._2.Dominio
{
    public class ImpuestoGanancias
    {
        public decimal Maximo = 34000;

        public decimal CalcularRetencion(decimal sueldo)
        {
            if (sueldo >= Maximo)
            {
                return sueldo * 0.65M;
            }

            return sueldo;
        }

    }
}