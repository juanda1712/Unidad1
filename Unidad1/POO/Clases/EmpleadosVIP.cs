using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad1.POO.Clases
{
    internal class EmpleadosVIP:Empleado
    {

        public override string Mostrar_Empleado()
        {
            return string.Concat("VIP", " y su bono es: ", bono);
        }


    }
}
