using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TallerDos
{
    public partial class Form1 : Form
    {
        private List<Empleado> listaEmpleados = new List<Empleado>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (listaEmpleados.Count >= 12)
            {
                MessageBox.Show("No se pueden agregar más de 12 empleados.");
                return;
            }

            string cedula = txtCedula.Text;
            string nombre = txtNombre.Text;

            Empleado empleado = new Empleado(cedula, nombre);
            listaEmpleados.Add(empleado);

            MessageBox.Show("Empleado guardado correctamente.");

            txtCedula.Text = "";
            txtNombre.Text = "";
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            string lista = "";

            foreach (Empleado empleado in listaEmpleados)
            {
                lista += "Cédula: " + empleado.Cedula + "\t Nombre: " + empleado.Nombre + "\n";
            }

            MessageBox.Show(lista);
        }
    }

    public class Empleado
    {
        public string Cedula { get; set; }
        public string Nombre { get; set; }

        public Empleado(string cedula, string nombre)
        {
            Cedula = cedula;
            Nombre = nombre;
        }
    }
}
