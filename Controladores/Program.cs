using ProyectoPersonal.Servicios;


namespace ProyectoPersonal.Controladores
{
    class Program
    {
        /// <summary>
        /// Metodo de entrada de la aplicacion
        /// 021023 - ilp
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            MenuInterfaz mI = new MenuImplementacion();

            mI.mostrarMensajeBienvenida();
            //variable que controla la entrada y la salida del bucle
            bool cerrarMenu = false;

            int opcionseleccionada;

            //desde la primera iteracion debe cumplirse la condicion
            while (!cerrarMenu)
            {
                opcionseleccionada = mI.mostrarMenuYSeleccion();
                Console.WriteLine(opcionseleccionada);
                switch (opcionseleccionada)
                {
                    case 0:
                        Console.WriteLine("[INFO] -Se ejecuta caso 0");
                        cerrarMenu = true;
                        break;
                    case 1:
                        Console.WriteLine("[INFO] -Se ejecuta caso 1 ");
                        break;
                    case 2:
                        Console.WriteLine("[INFO] -Se ejecuta caso 2 ");
                        break;
                    case 3:
                        Console.WriteLine("[INFO] -Se ejecuta caso 3 ");
                        break;
                    case 4:
                        Console.WriteLine("[INFO] -Se ejecuta caso 4 ");
                        break;
                    case 5:
                        Console.WriteLine("[INFO] -Se ejecuta caso 5 ");
                        break;
                    default:
                        Console.WriteLine("[INFO] - La opcion selecionada no coincide con ninguna ");
                        break;
                }
            }
        }
    }
}
