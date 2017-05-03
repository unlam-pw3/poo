namespace Ejemplo.MVC._2.Dominio
{
    public class AporteJubilacion : IAporte
    {
        public decimal Aplicar(decimal sueldo)
        {
            return sueldo - (sueldo * 0.03M);
        }
    }
}