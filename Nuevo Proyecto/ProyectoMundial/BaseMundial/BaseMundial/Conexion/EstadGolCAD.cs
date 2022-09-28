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
    internal class EstadGolCAD
    {
        public static bool GuardarEstadGol(EstadGol e)
        {
            try
            {
                Conexion con = new Conexion();
                string sql = "INSERT INTO Estad_Gol VALUES ('" + e.Cod_Jugad + "', '" + e.No_Ronda + "', '" + e.No_Bombo + "', '" + e.Cod_Selecc + "', '" + e.Min_Gol + "', '" + e.Asist_gol + "', '" + e.Tipo_gol + "')";
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
                string sql = "SELECT * FROM  Estad_Gol;";
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

        public static EstadGol consultar(string cod_Jugad)
        {
            try
            {
                Conexion con = new Conexion();
                string sql = "SELECT * FROM  Estad_Gol WHERE Cod_Jugad ='" + cod_Jugad + "';";
                SqlCommand comando = new SqlCommand(sql, con.conectar());
                SqlDataReader dr = comando.ExecuteReader();

                EstadGol em = new EstadGol();
                if (dr.Read())
                {
                    em.Cod_Jugad = dr["Cod_Jugad"].ToString();
                    em.No_Ronda = Convert.ToInt32(dr["No_Ronda"].ToString());
                    em.No_Bombo = Convert.ToInt32(dr["No_Bombo"].ToString());
                    em.Cod_Selecc = dr["Cod_Selecc"].ToString();
                    em.Min_Gol = Convert.ToInt32(dr["Min_Gol"].ToString());
                    em.Asist_gol = dr["Asist_gol"].ToString();
                    em.Tipo_gol = dr["tipo_gol"].ToString();

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

        public static bool actualizar(EstadGol e)
        {
            try
            {
                Conexion con = new Conexion();
                string sql = "UPDATE Estad_Gol SET No_Ronda='" + e.No_Ronda + "',No_Bombo='" + e.No_Bombo + "', Cod_Selecc='" + e.Cod_Selecc + "', Min_Gol='" + e.Min_Gol + "', Asist_gol='" + e.Asist_gol + "', tipo_gol='" + e.Tipo_gol + "' where Cod_Jugad='" + e.Cod_Jugad + "'";
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
                string sql = "DELETE FROM Estad_Gol where Cod_Jugad='" + cod_Jugad + "'";
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
