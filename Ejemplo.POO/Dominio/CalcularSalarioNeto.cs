using System.Collections.Generic;

namespace Ejemplo.MVC._2.Dominio
{
    public class CalcularSalarioNeto
    {
        private readonly IList<IAporte> _aportes;
        private readonly ImpuestoGanancias _ganancias;

        public CalcularSalarioNeto(IList<IAporte> aportes, ImpuestoGanancias ganancias)
        {
            _aportes = aportes;
            _ganancias = ganancias;
        }

        public decimal Calcular(ICalcularSueldoBruto empleado)
        {
            var sueldoBruto = empleado.Calcular();

            var sueldoNeto = CalcularAportes(sueldoBruto);

            return _ganancias.CalcularRetencion(sueldoNeto);
        }

        private decimal CalcularAportes(decimal sueldo)
        {
            foreach (var aporte in _aportes)
            {
                sueldo = aporte.Aplicar(sueldo);
            }
            return sueldo;
        }
    }
}