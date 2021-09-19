using System;

namespace Ejemplo2_con_switch

{
    class Program
    {
        struct estudiantes
        {
            public string Nombre;
            public int Edad;
            public float Estatura;
            public int Peso;
        }

        static void Main(string[] args)
        {
            estudiantes[] nuevo = new estudiantes[3];
            Program estudiantes = new Program();
            int opcion = 0;
            while (opcion != 4)
            {
                int opcionTres = 0;
                Console.WriteLine(string.Format("{0}             Menu               {0}{0}1. Almacenar nombres de 3 estudiantes{0}2. Lista de nombres almacenados{0}3. Buscar datos de los estudiantes{0}4. Salir", Environment.NewLine));
                Console.Write(string.Format("{0}Elija una opcion: ", Environment.NewLine));
                opcionTres = int.Parse(Console.ReadLine());
                switch (opcionTres)
                {
                    case 1:
                        estudiantes.Nombres();
                        Console.Clear();
                        break;
                    case 2:
                        estudiantes.ListadeNombres();
                        Console.Clear();
                        break;
                    case 3:
                        estudiantes.Buscar();
                        Console.Clear();
                        break;
                    case 4:
                        Console.WriteLine("¡Hasta luego!");
                        Console.ReadKey();
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine(string.Format("Por favor escoja una opcion del Menu{0}Pulse enter para continuar", Environment.NewLine));
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            }
        }
        public void Nombres()
        {

            estudiantes[] nuevo = new estudiantes[3];
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(string.Format("Ingrese el {0}º nombre", i + 1, Environment.NewLine));

                Console.Write(string.Format("{0}Nombre: ", Environment.NewLine));
                nuevo[i].Nombre = Console.ReadLine();

                Console.Write("Edad: ");
                nuevo[i].Edad = int.Parse(Console.ReadLine());

                Console.Write("Estatura: ");
                nuevo[i].Estatura = float.Parse(Console.ReadLine());

                Console.Write("Peso: ");
                nuevo[i].Peso = int.Parse(Console.ReadLine());

            }

            Console.WriteLine("Datos guardados exitosamente!");
            Console.WriteLine("Presione enter para continuar");
            Console.ReadKey();
        }
        public void ListadeNombres()
        {
            estudiantes[] nuevo = new estudiantes[3];
            Console.WriteLine(string.Format("{0}Lista de nombres ingresados{0}", Environment.NewLine));
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(nuevo[i].Nombre);
            }
            Console.WriteLine(string.Format("{0}Presione enter para continuar{0}", Environment.NewLine));
            Console.ReadKey();
        }
        public void Buscar()
        {
            estudiantes[] nuevo = new estudiantes[3];
            for (int i = 0; i < 3; i++)
            {
                string nombre;
                Console.WriteLine(string.Format("{0}Ingrese el nombre del que desea obtener los datos{0}", Environment.NewLine));
                nombre = Console.ReadLine();

                for (int ii = 0; ii < 3; ii++)
                {
                    if (nuevo[i].Nombre == nombre)
                    {
                        Console.WriteLine(string.Format("{0}Nombre: " + nuevo[i].Nombre + "{0}Edad: " + nuevo[i].Edad + "{0}Estatura: " + nuevo[i].Estatura + "{0}Peso: " + nuevo[i].Peso, Environment.NewLine));
                    }
                }
            }

            Console.WriteLine(string.Format("{0}Presione enter para continuar{0}", Environment.NewLine));
            Console.ReadKey();
        }
    }
}

