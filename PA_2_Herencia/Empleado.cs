using System;

namespace Herencia
{
    class Empleado
    {
        public string Nombre { get; set; }

        public virtual void RealizarTrabajo()
        {
            Console.WriteLine($"[GENERAL] {Nombre} está trabajando.");

        }
    }
}
