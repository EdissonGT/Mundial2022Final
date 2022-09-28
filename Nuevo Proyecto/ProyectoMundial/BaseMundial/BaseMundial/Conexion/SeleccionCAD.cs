using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseMundial.Datos;

namespace BaseMundial.Conexion
{
    internal class SeleccionCAD
    {
        public static DataTable Listar()
        {
            try
            {
                Conexion con = new Conexion();
                string sql = "SELECT * FROM  Seleccion;";
                SqlCommand comando = new SqlCommand(sql, con.conectar());
                SqlDataReader dr = comando.ExecuteReader(CommandBehavior.CloseConnection);
                DataTable dt = new DataTable();
                dt.Load(dr);

                con.desconectar();
                return dt;

            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static Seleccion consultar(string cod_Selecc)
        {
            try
            {
                Conexion con = new Conexion();
                string sql = "SELECT * FROM  Seleccion WHERE Cod_Selecc ='" + cod_Selecc + "';";
                SqlCommand comando = new SqlCommand(sql, con.conectar());
                SqlDataReader dr = comando.ExecuteReader();

                Seleccion em = new Seleccion();
                if (dr.Read())
                {
                    em.Cod_Selecc = dr["Cod_Selecc"].ToString();
                    em.Nom_Selecc = dr["Nom_Selecc"].ToString();
                    em.Entrenador = dr["Entrenador"].ToString();
                    em.No_Bombo = Convert.ToInt32(dr["No_Bombo"].ToString());
                    con.desconectar();
                    return em;
                }
                else
                {

                    con.desconectar();
                    return null;
                }

            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
