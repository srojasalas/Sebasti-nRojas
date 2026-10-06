using System;

namespace SebastiánRojas
{
    internal class Program
    {
        static readonly int N = 16;

        static string[] paciente = new string[N];
        static int[] gravedad = new int[N];

        static void IngresarPacientes()
        {
            for (int i = 0; i < paciente.Length; i++)
            {
                Console.Write($"Ingrese el nombre del paciente [{i + 1}]: ");
                paciente[i] = Console.ReadLine();
                Console.Write($"Ingrese el nivel de gravedad (1 al 5) para {paciente[i]}: ");
                gravedad[i] = int.Parse(Console.ReadLine());
            }
        }

        static void MostrarPaciente()
        {
            bool encontrado = false;
            Console.Write("Digite el nombre del paciente a buscar: ");
            string nomb = Console.ReadLine();

            for (int i = 0; i < paciente.Length; i++)
            {
                if (paciente[i] == nomb)
                {
                    Console.WriteLine($"El paciente {paciente[i]} tiene una gravedad de {gravedad[i]}");
                    encontrado = true;
                    break;
                }
            }

            if (!encontrado)
            {
                Console.WriteLine("No encontrado");
            }
        }

        static void ModificarPaciente()
        {
            bool encontrado = false;
            Console.Write("Digite el nombre del paciente a modificar: ");
            string nomb = Console.ReadLine();

            for (int i = 0; i < paciente.Length; i++)
            {
                if (paciente[i] == nomb)
                {
                    Console.WriteLine($"El paciente {paciente[i]} tiene una gravedad de {gravedad[i]}");
                    Console.Write("Digite el nuevo nombre: ");
                    paciente[i] = Console.ReadLine();
                    Console.Write("Digite la nueva gravedad (1 al 5): ");
                    gravedad[i] = int.Parse(Console.ReadLine());
                    encontrado = true;
                    break;
                }
            }

            if (!encontrado)
            {
                Console.WriteLine("No encontrado");
            }
        }

        static void EliminarPaciente()
        {
            bool encontrado = false;
            Console.Write("Digite el nombre del paciente a eliminar: ");
            string nomb = Console.ReadLine();

            for (int i = 0; i < paciente.Length; i++)
            {
                if (paciente[i] == nomb)
                {
                    encontrado = true;

                    for (int j = i; j < paciente.Length - 1; j++)
                    {
                        paciente[j] = paciente[j + 1];
                        gravedad[j] = gravedad[j + 1];
                    }

                    paciente[paciente.Length - 1] = "";
                    gravedad[paciente.Length - 1] = 0;

                    Console.WriteLine("Paciente eliminado");
                    break;
                }
            }

            if (!encontrado)
            {
                Console.WriteLine("No encontrado");
            }
        }

        static void ReportePacientes()
        {
            Console.WriteLine("------ Reporte de Pacientes ------");
            Console.WriteLine(" Nombre                 Nivel de gravedad");

            for (int i = 0; i < paciente.Length; i++)
            {
                if (!string.IsNullOrEmpty(paciente[i]))
                {
                    Console.WriteLine($" {paciente[i]}                  {gravedad[i]}");
                }
            }

        }

        static void Menu()
        {
            int opcion = 0;

            do
            {
                Console.WriteLine("\n1. Ingresar Pacientes");
                Console.WriteLine("2. Mostrar Paciente");
                Console.WriteLine("3. Modificar Paciente");
                Console.WriteLine("4. Eliminar Paciente");
                Console.WriteLine("5. Reporte");
                Console.WriteLine("6. Salir");
                Console.Write("Ingrese una opción: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        IngresarPacientes();
                        break;
                    case 2:
                        MostrarPaciente();
                        break;
                    case 3:
                        ModificarPaciente();
                        break;
                    case 4:
                        EliminarPaciente();
                        break;
                    case 5:
                        ReportePacientes();
                        break;
                    case 6:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("opcion incorrecta");
                        break;
                }

            } while (opcion != 6);
        }

        static void Main(string[] args)
        {
            Menu();
        }
    }
}