using BaseMundial.Conexion;
using BaseMundial.Datos;
using System;
using System.Data;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;


namespace BaseMundial
{
    public partial class FormSelecciones : Form
    {
        public FormSelecciones()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void llenarGrid()
        {
            DataTable datos = SeleccionCAD.Listar();
            if (datos == null)
            {
                MessageBox.Show("No se logro acceder a los datos");
            }
            else
            {
                dgSeleccion.DataSource = datos.DefaultView;
            }
        }

        private void FormSelecciones_Load(object sender, EventArgs e)
        {
            llenarGrid();

        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if (txtseleccion.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un Id");
            }
            else
            {
                Seleccion em = SeleccionCAD.consultar(txtseleccion.Text.Trim());
                if (em == null)
                {
                    MessageBox.Show("No existe el Jugador con Id " + txtseleccion.Text);
                    //limpiarCampos();
                    //consultado = false;
                }
                else
                {
                    txtseleccion.Text = em.Cod_Selecc;
                    txtnombre.Text = em.Nom_Selecc;
                    txtentrenador.Text = em.Entrenador;
                    txtbombo.Text = em.No_Bombo.ToString();
                    //consultado = true;
                }
            }
        }
    }
}
