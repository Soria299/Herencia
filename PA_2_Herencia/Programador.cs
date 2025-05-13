using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Programador : Empleado
    {
        public string LenguajeProgramacion { get; set; }

        public override void RealizarTrabajo()
        {
            Console.WriteLine($"[PROGRAMADOR]  {Nombre} está programando código en {LenguajeProgramacion}.");
        }

        public void Depurar()
        {
            Console.WriteLine($"[DEBUG] {Nombre} está depurando el código.");
        }
    }
}
