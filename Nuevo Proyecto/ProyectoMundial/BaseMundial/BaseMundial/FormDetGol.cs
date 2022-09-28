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
using static System.Net.Mime.MediaTypeNames;

namespace BaseMundial
{
    public partial class FormDetGol : Form
    {
        public FormDetGol()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void llenarGrid()
        {
            DataTable datos = PlantillaCAD.Listar();
            if (datos == null)
            {
                MessageBox.Show("No se logro acceder a los datos");
            }
            else
            {
                dgPlantilla.DataSource = datos.DefaultView;
            }
        }

        private void FormDetGol_Load(object sender, EventArgs e)
        {
            llenarGrid();
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
                    Plantilla em = new Plantilla();
                    em.Cod_Jugad = txtcodjuga.Text.Trim();
                    em.Cod_Selecc = txtcodsele.Text.Trim();
                    em.Nom_Jugad = txtnombre.Text.Trim();
                    em.Apell_Jugad = txtapelli.Text.Trim();
                    em.Date_Naci = dtpFecha.Value.Year + "-" + dtpFecha.Value.Month + "-" + dtpFecha.Value.Day;
                    em.Club_Jugad = txtclubjuga.Text.Trim();
                    em.Min_play = Convert.ToInt32(txtnimjuga.Text.Trim());
                    em.Goles_Jugad = Convert.ToInt32(txtgolanota.Text.Trim());
                    em.Asist_Jugad = Convert.ToInt32(txtasis.Text.Trim());
 


                    if (PlantillaCAD.GuardarPlantilla(em))
                    {
                        llenarGrid();
                        //limpiarCampos();
                        MessageBox.Show("Jugador Guardado");
                    }
                    else
                    {
                        MessageBox.Show("Ya existe el Id del Jugador");
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
            if (txtcodjuga.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un Id");
            }
            else
            {
                Plantilla em = PlantillaCAD.consultar(txtcodjuga.Text.Trim());
                if (em == null)
                {
                    MessageBox.Show("No existe el Jugador con Id " + txtcodjuga.Text);
                    //limpiarCampos();
                    consultado = false;
                }
                else
                {
                    txtcodjuga.Text = em.Cod_Jugad;
                    txtcodsele.Text = em.Cod_Selecc;
                    txtnombre.Text = em.Nom_Jugad;
                    txtapelli.Text = em.Apell_Jugad;
                    dtpFecha.Text = em.Date_Naci;
                    txtclubjuga.Text = em.Club_Jugad;
                    txtnimjuga.Text = em.Min_play.ToString();
                    txtgolanota.Text = em.Goles_Jugad.ToString();
                    txtasis.Text = em.Asist_Jugad.ToString();

                    consultado = true;
                }
            }
        }

        bool consultado = false;
        private void btneditar_Click(object sender, EventArgs e)
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
                    Plantilla em = new Plantilla();
                    em.Cod_Jugad = txtcodjuga.Text;
                    em.Cod_Selecc = txtcodsele.Text;
                    em.Nom_Jugad = txtnombre.Text;
                    em.Apell_Jugad = txtapelli.Text;
                    em.Date_Naci = dtpFecha.Value.Year + "-" + dtpFecha.Value.Month + "-" + dtpFecha.Value.Day;
                    em.Club_Jugad = txtclubjuga.Text;
                    em.Min_play = Convert.ToInt32(txtnimjuga.Text);
                    em.Goles_Jugad = Convert.ToInt32(txtgolanota.Text);
                    em.Asist_Jugad = Convert.ToInt32(txtasis.Text);


                    if (PlantillaCAD.actualizar(em))
                    {
                        llenarGrid();
                        //limpiarCampos();
                        MessageBox.Show("Jugador Actualizado");
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


                    if (PlantillaCAD.eliminar(txtcodjuga.Text.Trim()))
                    {
                        llenarGrid();
                        //limpiarCampos();
                        MessageBox.Show("Jugador Eliminado Correctamente");
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
