﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inventarioSP
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Datos.clsConexion obj = new Datos.clsConexion();
            Int16 b = obj.autenticar(txtUsuario.Text,txtContra.Text);

            if (b == 1)
            {
                Vista.Principal frmprin = new Vista.Principal();
                this.Hide();
                frmprin.ShowDialog();
                
            } else
            {
                MessageBox.Show("Contraseña o usuario incorrecto");
                txtContra.Text = "";
                txtUsuario.Text = "";
            }
            
        }
    }
}
