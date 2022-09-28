using BaseMundial.Conexion;
using BaseMundial.Datos;
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
    public partial class FormEstadisPais : Form
    {
        public FormEstadisPais()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void llenarGrid()
        {
            DataTable datos = EstadGolCAD.Listar();
            if (datos == null)
            {
                MessageBox.Show("No se logro acceder a los datos");
            }
            else
            {
                dgGol.DataSource = datos.DefaultView;
            }
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (txtcodjuga.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un Id valido");
            }
            else
            {
                try
                {
                    EstadGol em = new EstadGol();
                    em.Cod_Jugad = txtcodjuga.Text.Trim();
                    em.No_Ronda = Convert.ToInt32(txtnoronda.Text.Trim());
                    em.No_Bombo = Convert.ToInt32(txtnobombo.Text.Trim());
                    em.Cod_Selecc = txtcodsele.Text.Trim();
                    em.Min_Gol = Convert.ToInt32(txtnimgol.Text.Trim());
                    em.Asist_gol = txtasisgol.Text.Trim();
                    em.Tipo_gol = txttipogol.Text.Trim();


                    if (EstadGolCAD.GuardarEstadGol(em))
                    {
                        llenarGrid();
                        //limpiarCampos();
                        MessageBox.Show("Goles Guardados");
                    }
                    else
                    {
                        MessageBox.Show("Ya existe el Id del Gol");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void FormEstadisPais_Load(object sender, EventArgs e)
        {
            llenarGrid();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if (txtcodjuga.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un Id");
            }
            else
            {
                EstadGol em = EstadGolCAD.consultar(txtcodjuga.Text.Trim());
                if (em == null)
                {
                    MessageBox.Show("No existe el Gol con Id " + txtcodjuga.Text);
                    //limpiarCampos();
                    consultado = false;
                }
                else
                {
                    txtcodjuga.Text = em.Cod_Jugad;
                    txtnoronda.Text = em.No_Ronda.ToString();
                    txtnobombo.Text = em.No_Bombo.ToString();
                    txtcodsele.Text = em.Cod_Selecc;
                    txtnimgol.Text = em.Min_Gol.ToString();
                    txtasisgol.Text = em.Asist_gol;
                    txttipogol.Text = em.Tipo_gol;


                    consultado = true;
                }
            }
        }

        bool consultado = false;

        private void btbmodificar_Click(object sender, EventArgs e)
        {
            if (consultado == false)
            {
                MessageBox.Show("Debe consultar el jugador");
            }
            else if (txtcodjuga.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un Id valido");
            }
            else
            {
                try
                {
                    EstadGol em = new EstadGol();
                    em.Cod_Jugad = txtcodjuga.Text;
                    em.No_Ronda = Convert.ToInt32(txtnoronda.Text);
                    em.No_Bombo = Convert.ToInt32(txtnobombo.Text);
                    em.Cod_Selecc = txtcodsele.Text;
                    em.Min_Gol = Convert.ToInt32(txtnimgol.Text);
                    em.Asist_gol = txtasisgol.Text;
                    em.Tipo_gol = txttipogol.Text;


                    if (EstadGolCAD.actualizar(em))
                    {
                        llenarGrid();
                        //limpiarCampos();
                        MessageBox.Show("Goles Actualizados");
                        consultado = false;
                    }
                    else
                    {
                        MessageBox.Show("No se logro Actualizar");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (consultado == false)
            {
                MessageBox.Show("Debe consultar el jugador");
            }
            else if (txtcodjuga.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un Id valido");
            }
            else
            {
                try
                {


                    if (EstadGolCAD.eliminar(txtcodjuga.Text.Trim()))
                    {
                        llenarGrid();
                        //limpiarCampos();
                        MessageBox.Show("Eliminado Correctamente");
                        consultado = false;
                    }
                    else
                    {
                        MessageBox.Show("No se logro Eliminar");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
