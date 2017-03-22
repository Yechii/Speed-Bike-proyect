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
    public partial class EditarProductos : Form
    {
        public EditarProductos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Vista.Principal obj = new Vista.Principal();

            Pojos.clsVariables objVariables = new Pojos.clsVariables();
            Datos.clsConexion objConexion = new Datos.clsConexion();

            objVariables.NOMBRE = txtNombre.Text;
            objVariables.CODIGO = txtCodigo.Text;
            objVariables.CATEGORIA = cmbCategoria.Text;
            objVariables.CANTIDAD = Int32.Parse(txtCantiadad.Text);
            objVariables.COLOR_SABOR = txtcolorSabor.Text;
            objVariables.PRECIO = Int32.Parse(txtPrecio.Text);
            objVariables.MARCA = txtMarca.Text;


            objConexion.BuscarPro(objVariables);

            if ("1" == objVariables.CODIGO)

            {

                objVariables.CODIGO = txtCodigo.Text;
                objConexion.editar(objVariables);
                MessageBox.Show("Medicamento Modificado", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                obj.llenarT();
            }
            else
            {
                MessageBox.Show("El codogo no se puede editar");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
