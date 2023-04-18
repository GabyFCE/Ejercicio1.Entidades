using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Entidades
{
    internal static class MenuPrincipal
    {
        public static void Mostrar()
        {
            Console.WriteLine("Menu principal");
            Console.WriteLine("1-Alta de persona");
            Console.WriteLine("2-Baja de persona");
            Console.WriteLine("3-Modificar de persona");
            Console.WriteLine("4-Alta de persona");

            while (true)
            {
                Console.WriteLine("ingrese su opción:");
                var ingreso = Console.ReadLine();
                if (!int.TryParse(ingreso, out var opcion))
                {
                    Console.WriteLine("Ingrese un numero válido");
                    continue;
                }

                if (opcion > 1 || opcion > 4)
                {
                    Console.WriteLine("Ingrese 1-4");
                    continue;
                }

                switch (opcion)
                {
                    case 1:
                        ModuloPersonas.Alta();
                        break;

                    case 2:
                        ModuloPersonas.Baja();
                        break;

                    case 3:
                        ModuloPersonas.Modificar();
                        break;

                    case 4: //finalizar
                        return;
                }

                break;
            }


        }
    }
}
