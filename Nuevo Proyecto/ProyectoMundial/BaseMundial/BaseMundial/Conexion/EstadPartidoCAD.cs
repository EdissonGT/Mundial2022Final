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
    internal class EstadPartidoCAD
    {
        public static bool GuardarEstadPartido(EstadPartido e)
        {
            try
            {
                Conexion con = new Conexion();
                string sql = "INSERT INTO Estad_Partido VALUES ('" + e.Cod_Selecc + "', '" + e.No_Ronda + "', '" + e.No_Bombo + "', '" + e.Goles + "', '" + e.Tarj_Amari + "', '" + e.Tarj_Roja + "', '" + e.Tiro_alArco + "', '" + e.Tiro_Desv + "', '" + e.Tiro_Esquina + "')";
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
                string sql = "SELECT * FROM  Estad_Partido;";
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

        public static EstadPartido consultar(string cod_Selecc)
        {
            try
            {
                Conexion con = new Conexion();
                string sql = "SELECT * FROM  Estad_Partido WHERE Cod_Selecc ='" + cod_Selecc + "';";
                SqlCommand comando = new SqlCommand(sql, con.conectar());
                SqlDataReader dr = comando.ExecuteReader();

                EstadPartido em = new EstadPartido();
                if (dr.Read())
                {
                    em.Cod_Selecc = dr["Cod_Selecc"].ToString();
                    em.No_Ronda = Convert.ToInt32(dr["No_Ronda"].ToString());
                    em.No_Bombo = Convert.ToInt32(dr["No_Bombo"].ToString());
                    em.Tarj_Amari = Convert.ToInt32(dr["Tarj_Amari"].ToString());
                    em.Tarj_Roja = Convert.ToInt32(dr["Tarj_Roja"].ToString());
                    em.Tiro_alArco = Convert.ToInt32(dr["Tiro_alArco"].ToString());
                    em.Tiro_Desv = Convert.ToInt32(dr["Tiro_Desv"].ToString());
                    em.Tiro_Esquina = Convert.ToInt32(dr["Tiro_Esquina"].ToString());

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

        public static bool actualizar(EstadPartido e)
        {
            try
            {
                Conexion con = new Conexion();
                string sql = "UPDATE Estad_Partido SET No_Ronda='" + e.No_Ronda + "',No_Bombo='" + e.No_Bombo + "', Goles='" + e.Goles + "', Tarj_Amari='" + e.Tarj_Amari + "', Tarj_Roja='" + e.Tarj_Roja + "', Tiro_alArco='" + e.Tiro_alArco + "', Tiro_Desv='" + e.Tiro_Desv + "', Tiro_Esquina='" + e.Tiro_Esquina + "' where Cod_Selecc='" + e.Cod_Selecc + "'";
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

        public static bool eliminar(string cod_Selecc)
        {
            try
            {
                Conexion con = new Conexion();
                string sql = "DELETE FROM Estad_Partido where Cod_Selecc='" + cod_Selecc + "'";
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
