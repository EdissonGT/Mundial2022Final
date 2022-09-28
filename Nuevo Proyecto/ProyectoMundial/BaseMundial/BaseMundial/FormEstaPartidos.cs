
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
    public partial class FormEstaPartidos : Form
    {
        public FormEstaPartidos()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormEstaPartidos_Load(object sender, EventArgs e)
        {
            llenarGrid();
        }

        private void llenarGrid()
        {
            DataTable datos = EstadPartidoCAD.Listar();
            if (datos == null)
            {
                MessageBox.Show("No se logro acceder a los datos");
            }
            else
            {
                dgEstadPartido.DataSource = datos.DefaultView;
            }
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (txtcodsele.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un Id valido");
            }
            else
            {
                try
                {
                    EstadPartido em = new EstadPartido();
                    em.Cod_Selecc = txtcodsele.Text.Trim();
                    em.No_Ronda = Convert.ToInt32(txtnoronda.Text.Trim());
                    em.No_Bombo = Convert.ToInt32(txtBombo.Text.Trim());
                    em.Goles = Convert.ToInt32(txtgol.Text.Trim());
                    em.Tarj_Amari = Convert.ToInt32(txttaramariilas.Text.Trim());
                    em.Tarj_Roja = Convert.ToInt32(txttarrojas.Text.Trim());
                    em.Tiro_alArco = Convert.ToInt32(txtrieoarco.Text.Trim());
                    em.Tiro_Desv = Convert.ToInt32(txtdes.Text.Trim());
                    em.Tiro_Esquina = Convert.ToInt32(txttiroesquina.Text.Trim());



                    if (EstadPartidoCAD.GuardarEstadPartido(em))
                    {
                        llenarGrid();
                        //limpiarCampos();
                        MessageBox.Show("Estadisticas del Partido Guardadas");
                    }
                    else
                    {
                        MessageBox.Show("Ya existe el Id de Estadisticas del Partido");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if (txtcodsele.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un Id");
            }
            else
            {
                EstadPartido em = EstadPartidoCAD.consultar(txtcodsele.Text.Trim());
                if (em == null)
                {
                    MessageBox.Show("No existe la Seleccion con Id " + txtcodsele.Text);
                    //limpiarCampos();
                    consultado = false;
                }
                else
                {
                    txtcodsele.Text = em.Cod_Selecc;
                    txtnoronda.Text = em.No_Ronda.ToString();
                    txtBombo.Text = em.No_Bombo.ToString();
                    txtgol.Text = em.Goles.ToString();
                    txttaramariilas.Text = em.Tarj_Amari.ToString();
                    txttarrojas.Text = em.Tarj_Roja.ToString();
                    txtrieoarco.Text = em.Tiro_alArco.ToString();
                    txtdes.Text = em.Tiro_Desv.ToString();
                    txttiroesquina.Text = em.Tiro_Esquina.ToString();


                    consultado = true;
                }
            }
        }

        bool consultado = false;

        private void btbmodificar_Click(object sender, EventArgs e)
        {
            if (consultado == false)
            {
                MessageBox.Show("Debe consultar la Seleccion");
            }
            else if (txtcodsele.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un Id valido");
            }
            else
            {
                try
                {
                    EstadPartido em = new EstadPartido();
                    em.Cod_Selecc = txtcodsele.Text;
                    em.No_Ronda = Convert.ToInt32(txtnoronda.Text);
                    em.No_Bombo = Convert.ToInt32(txtBombo.Text);
                    em.Goles = Convert.ToInt32(txtgol.Text);
                    em.Tarj_Amari = Convert.ToInt32(txttaramariilas.Text);
                    em.Tarj_Roja = Convert.ToInt32(txttarrojas.Text);
                    em.Tiro_alArco = Convert.ToInt32(txtrieoarco.Text);
                    em.Tiro_Desv = Convert.ToInt32(txtdes.Text);
                    em.Tiro_Esquina = Convert.ToInt32(txttiroesquina.Text);



                    if (EstadPartidoCAD.actualizar(em))
                    {
                        llenarGrid();
                        //limpiarCampos();
                        MessageBox.Show("Datos Actualizados");
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
                MessageBox.Show("Debe consultar el Codigo de la Seleccion");
            }
            else if (txtcodsele.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un Id valido");
            }
            else
            {
                try
                {


                    if (EstadPartidoCAD.eliminar(txtcodsele.Text.Trim()))
                    {
                        llenarGrid();
                        //limpiarCampos();
                        MessageBox.Show(" Eliminado Correctamente");
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
