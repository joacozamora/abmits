using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace ProyectoFinal
{
    public partial class FormInstituto : Form
    {

        Alumno NuevoAlumno;
        public FormInstituto()
        {
            InitializeComponent();
            //CrearDgv();
            //LlenarDGV();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_CargarAlumno_Click(object sender, EventArgs e)
        {
            int nGrabados = -1;
            //string Analitico = Check_Analitico();
            DateTime FechaNacimiento = FechaNacAlumno.Value;
            string fecha_nac = Fecha_Nacimiento(FechaNacimiento);

            NuevoAlumno = new Alumno(int.Parse(txb_dni.Text), txb_NomApAlumno.Text, fecha_nac, txb_email.Text, chbx_analitico.Enabled);

            //nGrabados = objNegProducto.abmProductos("Alta", NuevoProd);

            if (nGrabados == -1)
            {
                MessageBox.Show("No se pudo grabar el Producto en el sistema");

            }
            else
            {
                
                //nuevo = true;
                //LlenarDGV();
            }

            MessageBox.Show("Producto Instanciado");

        }

        private string Fecha_Nacimiento(DateTime fecha)
        {
            string fechastring = fecha.ToString();
            string fechacorrecta = "";

            for (int i = 0; i < fechastring.Length; i++)
            {
                char letra = fechastring[i];
                if (letra == ' ')
                {
                    break;
                }
                fechacorrecta += letra.ToString();  
            }
            MessageBox.Show(fechacorrecta);
            return fechastring;
        }

        //private string Check_Analitico()
        //{
        //    string checkeado = "No";

        //    if (chbx_analitico.Checked )
        //    {
        //        checkeado = "Si";
        //    }
        //    return checkeado;
        //}
    }
}
