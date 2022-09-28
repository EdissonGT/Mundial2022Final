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
    internal class RondasCAD
    {
        public static bool GuardarRondas(Rondas e)
        {
            try
            {
                Conexion con = new Conexion();
                string sql = "INSERT INTO Rondas VALUES ('" + e.No_Ronda + "', '" + e.No_Bombo + "', '" + e.Cod_Selecc + "', '" + e.Goles_Ronda + "', '" + e.Tiro_alArco + "', '" + e.Tiro_Desv + "', '" + e.Tarj_Amari + "', '" + e.Tarj_Roja + "')";
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
                string sql = "SELECT * FROM  Rondas;";
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

        public static Rondas consultar(string cod_Selecc)
        {
            try
            {
                Conexion con = new Conexion();
                string sql = "SELECT * FROM  Rondas WHERE Cod_Selecc ='" + cod_Selecc + "';";
                SqlCommand comando = new SqlCommand(sql, con.conectar());
                SqlDataReader dr = comando.ExecuteReader();

                Rondas em = new Rondas();
                if (dr.Read())
                {
                    em.No_Ronda = Convert.ToInt32(dr["No_Ronda"].ToString());
                    em.No_Bombo = Convert.ToInt32(dr["No_Bombo"].ToString());
                    em.Cod_Selecc = dr["Cod_Selecc"].ToString();
                    em.Goles_Ronda = Convert.ToInt32(dr["Goles_Ronda"].ToString());
                    em.Tiro_alArco = Convert.ToInt32(dr["Tiro_alArco"].ToString());
                    em.Tiro_Desv = Convert.ToInt32(dr["Tiro_Desv"].ToString());
                    em.Tarj_Amari = Convert.ToInt32(dr["Tarj_Amari"].ToString());
                    em.Tarj_Roja = Convert.ToInt32(dr["Tarj_Roja"].ToString());

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

        public static bool actualizar(Rondas e)
        {
            try
            {
                Conexion con = new Conexion();
                string sql = "UPDATE Rondas SET No_Ronda='" + e.No_Ronda + "',No_Bombo='" + e.No_Bombo + "', Goles_Ronda='" + e.Goles_Ronda + "', Tiro_alArco='" + e.Tiro_alArco + "', Tiro_Desv='" + e.Tiro_Desv + "', Tarj_Amari='" + e.Tarj_Amari + "', Tarj_Roja='" + e.Tarj_Roja + "' where Cod_Selecc='" + e.Cod_Selecc + "'";
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
                string sql = "DELETE FROM Rondas where Cod_Selecc='" + cod_Selecc + "'";
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
