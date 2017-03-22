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
        public void llenarT()
        {
            Datos.clsConexion objconec = new Datos.clsConexion();
            dtgDatos.DataSource = objconec.llenar();
        }
        
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string bus = txtBuscar.Text;
            Datos.clsConexion objconec = new Datos.clsConexion();
            dtgDatos.DataSource = objconec.Buscar(bus);
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

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Vista.Agregar_Productos objAgr = new Vista.Agregar_Productos();
            objAgr.Show();

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Vista.EditarProductos obj = new Vista.EditarProductos();
            Pojos.clsVariables objVariables = new Pojos.clsVariables();
            Datos.clsConexion objConexion = new Datos.clsConexion();

            try
            {
                objVariables.CODIGO = dtgDatos.CurrentRow.Cells[0].Value.ToString();
                objVariables.NOMBRE = dtgDatos.CurrentRow.Cells[1].Value.ToString();
                objVariables.MARCA = dtgDatos.CurrentRow.Cells[2].Value.ToString();
                objVariables.CATEGORIA = dtgDatos.CurrentRow.Cells[3].Value.ToString();
                objVariables.PRECIO = Int32.Parse(dtgDatos.CurrentRow.Cells[4].Value.ToString());
                objVariables.CANTIDAD =Int32.Parse(dtgDatos.CurrentRow.Cells[5].Value.ToString());
                objVariables.COLOR_SABOR = dtgDatos.CurrentRow.Cells[6].Value.ToString();
             


                obj.txtNombre.Text = objVariables.NOMBRE;
                obj.txtCodigo.Text = objVariables.CODIGO;
                obj.txtMarca.Text = objVariables.MARCA;
                //obj.txtCategoria.Text = objVariables.CATEGORIA;
                obj.txtPrecio.Text=objVariables.PRECIO+"";
                obj.txtCantiadad.Text = objVariables.CANTIDAD+"";
                obj.txtcolorSabor.Text = objVariables.COLOR_SABOR;


                obj.Show();
                //this.Hide();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Pojos.clsVariables objVariables = new Pojos.clsVariables();
            Datos.clsConexion objConexion = new Datos.clsConexion();
            try
            {
                objVariables.CODIGO = dtgDatos.Rows[dtgDatos.SelectedRows[0].Index].Cells[0].Value.ToString();

                if (MessageBox.Show("Seguro que desea eliminar al Producto con codigo " +
              objVariables.CODIGO, "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
               == DialogResult.Yes)
                {
                    objConexion.EliminarPro(objVariables);
                    MessageBox.Show("Se Eliminado");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            Datos.clsConexion objconec = new Datos.clsConexion();
            dtgDatos.DataSource = objconec.llenar();

        }
    }
}
