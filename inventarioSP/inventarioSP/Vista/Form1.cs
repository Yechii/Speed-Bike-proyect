using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inventarioSP.Vista
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
            Datos.clsConexion objconec = new Datos.clsConexion();
            dtgDatos.DataSource = objconec.llenar();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string bus = txtBuscar.Text;
            Datos.clsConexion objconec = new Datos.clsConexion();
            dtgDatos.DataSource = objconec.Buscar(bus);
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBuscar_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            string bus = txtBuscar.Text;
            Datos.clsConexion objconec = new Datos.clsConexion();
            dtgDatos.DataSource = objconec.Buscar(bus);
        }
    }
}
