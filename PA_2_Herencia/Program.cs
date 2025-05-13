using System;


namespace  Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== DEMOSTRACIÓN DE POLIMORFISMO ===");
            Console.WriteLine("----------------------------------------");

            // Crear array de empleados (aplicando polimorfismo)
            Empleado[] empleados = new Empleado[3];

            // Asignar diferentes tipos de empleados al array
            empleados[0] = new Empleado { Nombre = "Tefy" };
            empleados[1] = new Programador { Nombre = "Arelys", LenguajeProgramacion = "C#" };
            empleados[2] = new Diseñador { Nombre = "Felipe", Especialidad = "UI/UX" };

            // Recorrer el array y llamar al método polimórfico
            Console.WriteLine("\nTrabajadores en acción:");
            Console.WriteLine("----------------------");
            foreach (Empleado emp in empleados)
            {
                // Esto demuestra el polimorfismo en acción:
                // El mismo método se comporta diferente según el tipo real del objeto
                emp.RealizarTrabajo();

                // Usando polimorfismo con operador 'is' y conversión
                if (emp is Programador prog)
                {
                    Console.WriteLine($"  → Experiencia en: {prog.LenguajeProgramacion}");
                }
                else if (emp is Diseñador dis)
                {
                    Console.WriteLine($"  → Especializado en: {dis.Especialidad}");
                }

                Console.WriteLine();
            }

            Console.WriteLine("\n=== TRABAJANDO EN EQUIPO ===");
            Console.WriteLine("--------------------------");
            ProyectoEquipo proyecto = new ProyectoEquipo();
            proyecto.AsignarEmpleados(empleados);
            proyecto.IniciarTrabajo();

            Console.WriteLine("\nPresione Enter para salir...");
            Console.ReadLine();
        }
    }
}
