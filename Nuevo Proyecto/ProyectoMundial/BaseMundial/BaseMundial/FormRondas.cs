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
    public partial class FormRondas : Form
    {
        public FormRondas()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void llenarGrid()
        {
            DataTable datos = RondasCAD.Listar();
            if (datos == null)
            {
                MessageBox.Show("No se logro acceder a los datos");
            }
            else
            {
                dgRondas.DataSource = datos.DefaultView;
            }
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (txtnoronda.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un Id valido");
            }
            else
            {
                try
                {
                    Rondas em = new Rondas();
                    em.No_Ronda = Convert.ToInt32(txtnoronda.Text.Trim());
                    em.No_Bombo = Convert.ToInt32(txtnobombo.Text.Trim());
                    em.Goles_Ronda = Convert.ToInt32(txtgolronda.Text.Trim());
                    em.Cod_Selecc = txtcodsele.Text.Trim();
                    em.Tiro_alArco = Convert.ToInt32(txttiroarco.Text.Trim());
                    em.Tiro_Desv = Convert.ToInt32(txttirodes.Text.Trim());
                    em.Tarj_Amari = Convert.ToInt32(txttaramarillas.Text.Trim());
                    em.Tarj_Roja = Convert.ToInt32(txttarrojas.Text.Trim());




                    if (RondasCAD.GuardarRondas(em))
                    {
                        //llenarGrid();
                        //limpiarCampos();
                        MessageBox.Show("Ronda Guardada");
                    }
                    else
                    {
                        MessageBox.Show("Ya existe el Id de Ronda de la Seleccion");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void FormRondas_Load(object sender, EventArgs e)
        {
            llenarGrid();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if (txtcodsele.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un Id");
            }
            else
            {
                Rondas em = RondasCAD.consultar(txtcodsele.Text.Trim());
                if (em == null)
                {
                    MessageBox.Show("No existe la Seleccion con Id " + txtcodsele.Text);
                    //limpiarCampos();
                    consultado = false;
                }
                else
                {
                    txtnoronda.Text = em.No_Ronda.ToString();
                    txtnobombo.Text = em.No_Bombo.ToString();
                    txtcodsele.Text = em.Cod_Selecc;
                    txtgolronda.Text = em.Goles_Ronda.ToString();
                    txttiroarco.Text = em.Tiro_alArco.ToString();
                    txttirodes.Text = em.Tiro_Desv.ToString();
                    txttaramarillas.Text = em.Tarj_Amari.ToString();
                    txttarrojas.Text = em.Tarj_Roja.ToString();

                    consultado = true;
                }
            }
        }

        bool consultado = false;

        private void btbmodificar_Click(object sender, EventArgs e)
        {
            if (consultado == false)
            {
                MessageBox.Show("Debe consultar el Codigo de Pais");
            }
            else if (txtcodsele.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un Id valido");
            }
            else
            {
                try
                {
                    Rondas em = new Rondas();
                    
                    em.No_Ronda = Convert.ToInt32(txtnoronda.Text);
                    em.No_Bombo = Convert.ToInt32(txtnobombo.Text);
                    em.Cod_Selecc = txtcodsele.Text;
                    em.Goles_Ronda = Convert.ToInt32(txtgolronda.Text);
                    em.Tiro_alArco = Convert.ToInt32(txttiroarco.Text);
                    em.Tiro_Desv = Convert.ToInt32(txttirodes.Text);
                    em.Tarj_Amari = Convert.ToInt32(txttaramarillas.Text);
                    em.Tarj_Roja = Convert.ToInt32(txttarrojas.Text);
                    



                    if (RondasCAD.actualizar(em))
                    {
                        llenarGrid();
                        //limpiarCampos();
                        MessageBox.Show("Rondas Actualizadas");
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
            else if (txtcodsele.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un Id valido");
            }
            else
            {
                try
                {


                    if (RondasCAD.eliminar(txtcodsele.Text.Trim()))
                    {
                        llenarGrid();
                        //limpiarCampos();
                        MessageBox.Show("Eliminado");
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
