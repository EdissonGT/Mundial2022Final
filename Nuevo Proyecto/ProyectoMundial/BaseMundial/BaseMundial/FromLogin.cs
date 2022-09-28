using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseMundial
{
    public partial class FromLogin : Form
    {
        public FromLogin()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtnombre_Enter(object sender, EventArgs e)
        {
            if (txtnombre.Text == "USUARIO")
            {
                txtnombre.Text = "";
                txtnombre.ForeColor = Color.Black;
            }
        }

        private void txtnombre_Leave(object sender, EventArgs e)
        {
            if (txtnombre.Text == "")
            {
                txtnombre.Text = "USUARIO";
                txtnombre.ForeColor = Color.DimGray;
            }
        }

        private void txtcontra_Enter(object sender, EventArgs e)
        {
            if (txtcontra.Text == "CONTRASEÑA")
            {
                txtcontra.Text = "";
                txtcontra.ForeColor = Color.Black;
                txtcontra.UseSystemPasswordChar = true;
            }
        }

        private void txtcontra_Leave(object sender, EventArgs e)
        {
            if (txtcontra.Text == "")
            {
                txtcontra.Text = "CONTRASEÑA";
                txtcontra.ForeColor = Color.DimGray;
                txtcontra.UseSystemPasswordChar = false;
            }
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            if (txtnombre.Text == "Admin" && txtcontra.Text == "1234")
            {
                MessageBox.Show("Sesion Iniciada");
                txtnombre.Text = "USUARIO";
                txtcontra.Text = "CONTRASEÑA";
                this.Hide();
                FormBienvenida v1 = new FormBienvenida();
                v1.Show();
            }
            
            else if(txtnombre.Text == "USUARIO" || txtcontra.Text == "CONTRASEÑA")
            {
                MessageBox.Show("Llene todos los campos");
                txtnombre.Text = "USUARIO";
                txtcontra.Text = "CONTRASEÑA";
            }
            else
            {
                MessageBox.Show("Los Datos Ingresados son Incorrectos");
                txtnombre.Text = "USUARIO";
                txtcontra.Text = "CONTRASEÑA";
            }
        }
    }
}
