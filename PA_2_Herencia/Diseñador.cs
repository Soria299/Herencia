using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Diseñador : Empleado
    {
        public string Especialidad { get; set; }

        public override void RealizarTrabajo()
        {
            Console.WriteLine($"[DISEÑADOR] {Nombre} está creando diseños {Especialidad}.");
        }

        public void CrearPrototipo()
        {
            Console.WriteLine($"[PROTOTIPO] {Nombre} está creando un prototipo.");
        }
    }
}
