using miFormularioTarea.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miFormularioTarea
{
    public partial class Form1 : Form
    {
        Crud miCrud = new Crud();


        public Form1()
        {
            InitializeComponent();
        }

        private void buttonBuscar_Click_1(object sender, EventArgs e)
        {
            textBoxEstudiante.Text = miCrud.MostrarInformacion(textBoxCarnet.Text);
            textBoxNotas.Text = miCrud.MostrarTareas(textBoxCarnet.Text);
            textBoxSeccion.Text = miCrud.MostrarInformacionSeccion(textBoxCarnet.Text);
            textBoxEmail.Text = miCrud.MostrarInformacionCorreo(textBoxCarnet.Text);
        }

        private void buttonCrear_Click_1(object sender, EventArgs e)
        {
            string nombre = textBoxEstudiante.Text;
            string carnet = textBoxCarnet.Text;
            string email = textBoxEmail.Text;
            string seccion = textBoxSeccion.Text;
            string respuesta = miCrud.AgregarAlumno(carnet, nombre, email, seccion);
            MessageBox.Show(respuesta);
        }

        private void buttonSaludar_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Hola te saludo desde el formulario");
        }


    }
}