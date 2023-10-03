using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPersonal.Servicios
{
    internal class MenuImplementacion:MenuInterfaz
    {
        public void mostrarMensajeBienvenida()
        {
            string mensaje = "cajero CS1";
            Console.WriteLine(mensaje);
        }
        public int mostrarMenuYSeleccion()
        {
            int opcionIntroducida;
            Console.WriteLine("##############################");
            Console.WriteLine("0. Cerrar aplicacion");
            Console.WriteLine("1.Darse de alta");
            Console.WriteLine("2.Ingresar dinero");
            Console.WriteLine("3.Sacar dinero");
            Console.WriteLine("4.Transferir dinero");
            Console.WriteLine("5.Historial de operaciones");
            Console.WriteLine("##############################");
            Console.WriteLine("Seleccione una opcion");

            opcionIntroducida = Console.ReadKey(true).KeyChar - ('0');
            return opcionIntroducida;
        }
    }
}
