using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unidad1.POO.Clases;

namespace Unidad1.POO.Views
{
    public partial class Welcome : Form
    {

        Empleado OBemp = new Empleado();
        EmpleadosVIP OBempl_vip = new EmpleadosVIP();
        Nomina OBNomina = new Nomina();  
        public Welcome()
        {
            InitializeComponent();
        }

        private void Welcome_Load(object sender, EventArgs e)
        {

        
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int temp_bono = OBemp.bono;
            OBemp.bono = 500;
            int cod_empleado= OBemp.CrearEmpleado("Juan","Lopez", 29);
            //if (OBemp.EliminarEmpleado(cod_empleado) == true)
            //{
            //    MessageBox.Show("Exito");
            //}

            MessageBox.Show(OBemp.Mostrar_Empleado());
            MessageBox.Show(OBempl_vip.Mostrar_Empleado());
            OBNomina.GenerarNomina(OBempl_vip);

            var val1 = Funciones.Multiplicar(1, 2);


        }
    }
}
