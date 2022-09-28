using BaseMundial.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseMundial.Conexion
{
    internal class PlantillaCAD
    {
        public static bool GuardarPlantilla(Plantilla e)
        {
            try
            {
                Conexion con = new Conexion();
                string sql = "INSERT INTO Plantilla VALUES ('" + e.Cod_Jugad + "', '" + e.Cod_Selecc + "', '" + e.Nom_Jugad + "', '" + e.Apell_Jugad + "', '" + e.Date_Naci + "', '" + e.Club_Jugad + "', '" + e.Min_play + "', '" + e.Goles_Jugad + "', '" + e.Asist_Jugad + "')";
                SqlCommand comando = new SqlCommand(sql, con.conectar());
                int cantidad = comando.ExecuteNonQuery();
                if (cantidad == 1)
                {
                    con.desconectar();
                    return true;
                }
                else return false;

            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static DataTable Listar()
        {
            try
            {
                Conexion con = new Conexion();
                string sql = "SELECT * FROM  Plantilla;";
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

        public static Plantilla consultar(string cod_Jugad)
        {
            try
            {
                Conexion con = new Conexion();
                string sql = "SELECT * FROM  Plantilla WHERE Cod_Jugad ='" + cod_Jugad + "';";
                SqlCommand comando = new SqlCommand(sql, con.conectar());
                SqlDataReader dr = comando.ExecuteReader();

                Plantilla em = new Plantilla();
                if (dr.Read())
                {
                    em.Cod_Jugad = dr["Cod_Jugad"].ToString();
                    em.Cod_Selecc = dr["Cod_Selecc"].ToString();
                    em.Nom_Jugad = dr["Nom_Jugad"].ToString();
                    em.Apell_Jugad = dr["Apell_Jugad"].ToString();
                    em.Date_Naci = dr["Date_Naci"].ToString();
                    em.Club_Jugad = dr["Club_Jugad"].ToString();
                    em.Min_play = Convert.ToInt32(dr["Min_play"].ToString());
                    em.Goles_Jugad = Convert.ToInt32(dr["Goles_Jugad"].ToString());
                    em.Asist_Jugad = Convert.ToInt32(dr["Asist_Jugad"].ToString());

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

        public static bool actualizar(Plantilla e)
        {
            try
            {
                Conexion con = new Conexion();
                string sql = "UPDATE Plantilla SET Cod_Selecc='" + e.Cod_Selecc + "',Nom_Jugad='" + e.Nom_Jugad + "', Apell_Jugad='" + e.Apell_Jugad + "', Date_Naci='" + e.Date_Naci + "', Club_Jugad='" + e.Club_Jugad + "', Min_play='" + e.Min_play + "', Goles_Jugad='" + e.Goles_Jugad + "', Asist_Jugad='" + e.Asist_Jugad + "' where Cod_Jugad='" + e.Cod_Jugad + "'";
                SqlCommand comando = new SqlCommand(sql, con.conectar());
                int cantidad = comando.ExecuteNonQuery();
                if (cantidad == 1)
                {
                    con.desconectar();
                    return true;
                }
                else
                {
                    con.desconectar();
                    return false;
                }


            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static bool eliminar(string cod_Jugad)
        {
            try
            {
                Conexion con = new Conexion();
                string sql = "DELETE FROM Plantilla where Cod_Jugad='" + cod_Jugad + "'";
                SqlCommand comando = new SqlCommand(sql, con.conectar());
                int cantidad = comando.ExecuteNonQuery();
                if (cantidad == 1)
                {
                    con.desconectar();
                    return true;
                }
                else
                {
                    con.desconectar();
                    return false;
                }


            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
