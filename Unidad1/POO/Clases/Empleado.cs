using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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


        private int _bono = 1000;

        public int bono
        {
            get { return _bono; }
            set {
                if (value > 100000)
                    MessageBox.Show("Bono no permitido");
                else
                    _bono = value;            
                }
        }


        public  Empleado()
        {
            id_empleado = 0;
            this.cedula = 0;
        }
        ~Empleado()
        {

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


        public virtual string Mostrar_Empleado()
        {
            return string.Concat("General"," y su bono es: " , _bono );
        }


    }
}
