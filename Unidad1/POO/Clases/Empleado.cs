using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad1.POO.Clases
{
    internal class Empleado
    {

        // atributos 
        private string nombre;
        private string apellido;
        private int edad;
        private int id_empleado;
        public int cedula;
        protected int id_area;


        public  Empleado()
        {
            id_empleado = 0;
            this.cedula = 0;
        }

        public Empleado(int ID_Empleado)
        {
            this.id_empleado = ID_Empleado;
        }

        public int CrearEmpleado(string nombre , string apellido , int edad )
        {
            return GenerarCod();
        }

        public bool EliminarEmpleado( int ID_Empleado)
        {
            return true;
        }

        private int GenerarCod()
        {

            Random rd = new Random();
            return rd.Next(0, 100);

        }



    }
}
