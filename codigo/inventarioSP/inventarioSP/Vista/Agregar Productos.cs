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
    public partial class Agregar_Productos : Form
    {
        public Agregar_Productos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Pojos.clsVariables objVariables = new Pojos.clsVariables();
            Datos.clsConexion objConexion = new Datos.clsConexion();

            objVariables.NOMBRE = txtNombre.Text;
            objVariables.CODIGO = txtCodigo.Text;
            objVariables.MARCA = txtMarca.Text;
            objVariables.CANTIDAD = Int32.Parse(txtCantidad.Text);
            objVariables.CATEGORIA = cmbCategoria.Text;
            objVariables.COLOR_SABOR = txtcolorSabor.Text;
            objVariables.PRECIO = Int32.Parse(txtPrecio.Text);


            objConexion.AgregarPro(objVariables);
            MessageBox.Show("Producto Registrado", "Agregar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
