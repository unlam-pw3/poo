namespace Ejemplo.MVC._2.Dominio.Entidades
{
    public abstract class Empleado
    {

        public string Nombre { get; private set; }
        public string Apellido { get; private set; }

        protected Empleado(string nombre, string apellido)
        {
            Nombre = nombre;
            Apellido = apellido;
        }
    }
}