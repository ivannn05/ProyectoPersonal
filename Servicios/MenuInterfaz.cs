using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPersonal.Servicios
{
    internal interface MenuInterfaz
    {
            /// <summary>
            /// Metodo que muestra el mensaje de bienvenida del concecionario
            /// 270923 - ilp
            /// </summary>

            public void mostrarMensajeBienvenida();

            /// <summary>
            /// Metodo que muestra el menu y recoge la selecion del usuario
            /// 270923 - ilp
            /// </summary>
            /// <returns></returns>

            public int mostrarMenuYSeleccion();
        }
}
