using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class ProyectoEquipo
    {
        private Empleado[] _miembrosEquipo;

        public void AsignarEmpleados(Empleado[] empleados)
        {
            _miembrosEquipo = empleados;
        }

        public void IniciarTrabajo()
        {
            if (_miembrosEquipo == null || _miembrosEquipo.Length == 0)
            {
                Console.WriteLine("No hay empleados asignados al proyecto.");
                return;
            }

            Console.WriteLine("Iniciando trabajo en equipo:");

            foreach (var empleado in _miembrosEquipo)
            {
                // Demostración de polimorfismo avanzado con switch pattern matching
                switch (empleado)
                {
                    case Programador programador:
                        Console.Write("  [FASE DESARROLLO] ");
                        programador.RealizarTrabajo();
                        programador.Depurar();
                        break;

                    case Diseñador diseñador:
                        Console.Write("  [FASE DISEÑO] ");
                        diseñador.RealizarTrabajo();
                        diseñador.CrearPrototipo();
                        break;

                    default:
                        Console.Write("  [FASE GESTIÓN] ");
                        empleado.RealizarTrabajo();
                        break;
                }
            }
        }
    }
}
