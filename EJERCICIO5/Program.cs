using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Xml;



/*Una central de distribución de químicos distribuye Alcohol hacia
diferentes almacenes sucursales. Disponen de un muelle de carga a donde
van llegando tanques de alcohol de entre 3000 y 9000 litros, con pesos
variables en función de las circunstancias de la producción. La empresa
dispone de una flota de camiones con capacidades de carga de entre 18000
y 28000 litros.
Se pretende establecer un protocolo consistente en cargar 20 camiones
diarios. Cada camión se quiere cargar como máximo a su límite de capacidad
debiendo partir si con la siguiente saca en la línea de producción se fuera a
exceder su capacidad.
4
La empresa quiere desarrollar una solución básica de programación que le
pida al operario encargado de carga la capacidad del camión y el peso de las
sacas, indicándole si debe cargar los tanques de alcohol o despachar el
camión para comenzar a cargar otro.*/

namespace Capacidad_camiones
{
    class program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("-----------------BIENVENIDO-----------------");
            Console.WriteLine("********************************************");
            Console.WriteLine("PROGRMA PARA VER LA CAPACIDAD DE 20 CAMIONES");
            Console.WriteLine("********************************************");
            Console.WriteLine("\n");

            for (int i = 1; i < 20; i++)
            {
                camion camion = new camion();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("INGRESE LA CAPACIDAD DEL CAMION {0}",i);
                camion.setcapacidad(int.Parse(Console.ReadLine()));
                Console.WriteLine("********************************************");

                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("INGRESE EL PESO DE LAS SACAS");
                camion.setsacas(int.Parse(Console.ReadLine()));
                Console.WriteLine("********************************************");

                if (camion.VerificarCapacidad())
                {
                    Console.ForegroundColor = ConsoleColor.DarkCyan; 
                    Console.WriteLine("EL CAMION NO CUENTA CON LA CAPACIDAD DEBE CARGAR DE NUEVO");
                    Console.WriteLine("*********************************************************");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("EL CAMION CUENTA CON LA CAPACIDAD");
                    Console.WriteLine("*********************************************************");
                }
                Console.WriteLine("Presione enter para el siguiente......");
                Console.ReadKey();
            }
;        }

    }
}
