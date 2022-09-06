using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unidad1.POO.Views;

namespace Unidad1
{
    public partial class Form1 : Form
    {
        int Numero = 0;
       


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            int Num1 = 0;
            long Num2;
            char ch;
            Double db;
            string nombre = txtNombre.Text;
            object casa = new { techo = "", puerta = "" };
            var cosa = Numero;




        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Num1 , Num2 = 0;
            long Num3;
            char ch;
            Double db;
            string nombre = txtNombre.Text;
            string substr;

            // CONVERS
            //cast X class
            //db = Double.Parse(txtNombre.Text);
            //Num1 = Int32.Parse(txtNombre.Text);
            //bool conv = Int32.TryParse(txtNombre.Text, out Num1)

            //Num1 = nombre.Length;
            //nombre = nombre.Trim();
            //substr = nombre.Substring(0, 5);
            //var temp = nombre.Replace("J", "D");

            // Asig Compuesta
            //Num1++;
            //Num1--;
            //Num1 += 40;

            //Num2 = suma(10 , 20 , 50);
            //var resul = suma("2", "4");

            ///// Concat and Format
            string resultado = "";
            ////resultado += " Juan";
            //resultado = string.Format("Mi Nombre es:{0} y la suma es: {1} Final",nombre,Num2.ToString());
            ////MessageBox.Show(String.Concat("El Resultado es:", nombre, " - ", temp, " Final"));

            // Condicional
            if(txtNombre.Text.Equals(""))
            {
                resultado = "";
            }
            else if (nombre == "")
            {

            }
            else { }


            //  Switch

            switch (nombre)
            {

                case "Juan":
                    Num1 = 1;
                    break;
                case "David":
                    Num1 = 1;
                    break;

                default:
                    break;
            }



            /// Ciclos 
            /// 
           
            Num2 = 0;
            while(Num2  <= 10)
            {
                resultado = "While";
                Num2++;
            }


            //do while

            do
            {
                MostrarMsj("Do");

            } while ( Num2 > 10);


            // for 

            for (int i = 0; i < Num2; i++)
            {              

            }


            ///


            MostrarMsj(resultado);
            limpiar();

           
        }


        private void limpiar()
        {
            txtNombre.Text = "";

        }

        private void MostrarMsj(string valor)
        {
            MessageBox.Show(valor);
        }


        //private int suma(int Num1 , int Num2)
        //{
        //    return Num1 + Num2;
        //}


        //private int suma(int Num1, int Num2) => Num1 + Num2;

        private int suma(int Num1, int Num2, int Num3 = 0 )
        {
            return Num1 + Num2 + Num3;
        }

        private double suma(string Num1, string Num2)
        {

            return Double.Parse( Num1) + Double.Parse(Num2);
        }



        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {


            /// Array
            int[] Numeros;
            Numeros = new int[5] {1,2,3,4,5};

            Numeros[0] = 1;
            Numeros[1] = 2;

            for (int i = 0; i < Numeros.Length -1; i++)
            {
                Numeros[i] = 1;
            }
            Array.Resize(ref Numeros, 10);

            // Matrices

            int[,] numeros2;
            numeros2 = new int[2, 2] { { 1, 2 }, { 3, 4 } };


            
            // Split 

            string nombre = txtNombre.Text;
            string[] vtsplit = nombre.Split(',');


        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<string> meses = new List<string>();

            meses.Add("Enero");
            meses.Add("Marzo");
            meses.Add("Junio");
            meses.Add("Agosto");

            meses.RemoveAt(0);
            meses.Remove("Marzo");
            meses.Clear();
            //string item = meses[0];

            //meses.Sort();
            //for (int i = 0; i < meses.Count; i++)
            //{

            //}

            foreach (var item in meses)
            {
                var  detalle = item.ToString();

            }

            Dictionary<int, string> User = new Dictionary<int, string>();

            User.Add(100,"Carlos");
            User.Add(200, "Juan");
            User.Add(300, "Ana");

            User.Remove(100);
            User.Clear();

            //User[100] = "David";

            foreach (var item in User)
            {
                string detalle = item.Value;
            }

            HashSet<int> conj = new HashSet<int>();
            conj.Add(100);
            conj.Add(200);
            conj.Add(100);


            DataTable dt_User = new DataTable();
            dt_User.Columns.Add("Cedula");
            dt_User.Columns.Add("Nombre");
            dt_User.Columns.Add("Ciudad");

            dt_User.Rows.Add();
            dt_User.Rows.Add(new object[] { "1093", "Juan", "Pereira" });

            DataRow dr_usr = dt_User.NewRow();
            dr_usr["Cedula"] = "1088";
            dr_usr["Nombre"] = "Carlos";
            dr_usr["Ciudad"] = "Cartago";
            dt_User.Rows.Add(dr_usr);

            string dato;

            foreach(DataRow dr in dt_User.Rows)
            {
                dato= dr["Nombre"].ToString();
            }

            dt_User.Rows[0]["Nombre"] = "David";


        }

        private void button4_Click(object sender, EventArgs e)
        {

            try
            {
                int Num;
                Num = int.Parse(txtNombre.Text);

                if (Num == 6)
                {
                    throw new FormatException();
                }


            }
            catch (FormatException Ex)
            {
                MessageBox.Show("Error en formato");
               
            }
            catch (OverflowException Ex)
            {
                MessageBox.Show("Error en Operación Art");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en sistema intente de nuevo ");

            }
            finally
            {
                txtNombre.Text = "";
          

            }


        }

        private void button5_Click(object sender, EventArgs e)
        {
            Welcome frm = new Welcome();
            frm.Show();
            this.Close();
           

        }
    }
}
