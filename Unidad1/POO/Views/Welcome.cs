﻿using System;
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
        public Welcome()
        {
            InitializeComponent();
        }

        private void Welcome_Load(object sender, EventArgs e)
        {

        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cod_empleado= OBemp.CrearEmpleado("Juan","Lopez", 29);            
            if (OBemp.EliminarEmpleado(cod_empleado) == true)
            {
                MessageBox.Show("Exito");
            }

        }
    }
}
