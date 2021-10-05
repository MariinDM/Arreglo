using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arregloss
{
    class Program
    {
        static void Main(string[] args)
        {
            int option;
            string letra;
            arre obj = new arre();
            do
            {
                Console.WriteLine("MENU PRINCIPAL");
                Console.WriteLine("1.- Inicializar/Borrar");
                Console.WriteLine("2.- Mostrar");
                Console.WriteLine("3.- Buscar");
                Console.WriteLine("4.- Insertar");
                Console.WriteLine("5.- Eliminar");
                Console.WriteLine("6.- Modificar");
                Console.WriteLine("7.- Creditos");
                Console.WriteLine("8.- Salir");
                Console.WriteLine("Ingrese un numero para continuar");
                option = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("----------------------------");
                switch (option)
                {
                    case 1:
                        obj.Inicializar();
                        Console.WriteLine("Arreglo Inicializado");
                        Console.WriteLine("----------------------------");
                        break;
                    case 2:
                        obj.Ordenar();
                        obj.Mostrar();
                        break;
                    case 3:
                        Console.WriteLine("Escribe una letra");
                        letra = Convert.ToString(Console.ReadLine());
                        obj.Buscar(letra);
                        Console.WriteLine("----------------------------");
                        break;
                    case 4:
                        Console.WriteLine("Escribe una letra");
                        letra = Convert.ToString(Console.ReadLine());
                        obj.Insertar(letra);
                        Console.WriteLine("----------------------------");
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    case 7:
                        Console.WriteLine("INTEGRANTES");
                        Console.WriteLine("DIEGO MARIN MONTALVO 20170132");
                        Console.WriteLine("JULIO CESAR MENA AGUILAR 20170157");
                        Console.WriteLine("JOSE ALEJANDRO PINEDA MAGALLANES 20170023");
                        break;
                }
            } while (option!=8);
            Console.ReadKey();
        }
    }
}
