using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    internal class MetodoDatos
    {
        //Metodo que nos regresa una tabla de información realizada con una consulta
        public static DataSet ExecuteDataSet(string sp, params object[] parametros)
        {
            DataSet ds = new DataSet();

            string cadenacConexion = Configuracion.CadenaConexion;

            SqlConnection conn = new SqlConnection(cadenacConexion);

            try
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                else
                {
                    SqlCommand cmd = new SqlCommand(sp, conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = sp;

                    if (parametros != null && parametros.Length % 2 != 0)
                    {
                        throw new Exception("Los parametross deben de venir en pares");
                    }
                    else
                    {
                        for (int i = 0; i < parametros.Length; i = i + 2)
                        {
                            cmd.Parameters.AddWithValue(parametros[i].ToString(), parametros[i + 1]);
                        }

                        conn.Open();

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        adapter.Fill(ds);

                        conn.Close();
                    }
                }
                return ds;
            }

            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        //Metodo que ejecuta un escalar 
        public static int ExecuteEscalar(string sp, params object[] parametros)
        {
            int id = 0;

            //Traer la cadena de conexión
            string cadenaConexion = Configuracion.CadenaConexion;

            //Crear la conexion
            SqlConnection conn = new SqlConnection(cadenaConexion);

            try
            {
                //Validamos si la conexion está abierta
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    //Si está abierta la cerramos
                    conn.Close();
                }
                else
                {
                    //Crear el SqlCommand
                    SqlCommand cmd = new SqlCommand(sp, conn);

                    //Se selecciona el tipo de comando y el se le envía el nombre del storedProocedure
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = sp;

                    //Agregan los parámetros
                    for (int i = 0; i < parametros.Length; i = i + 2)
                    {
                        cmd.Parameters.AddWithValue(parametros[i].ToString(), parametros[i + 1]);
                    }

                    //Abrir la conexion
                    conn.Open();

                    //Ejecutar el stored procedure
                    id = int.Parse(cmd.ExecuteScalar().ToString());

                    //Cerrar la conexion
                    conn.Close();

                }
                return id;
            }
            catch (Exception ex)
            {
                return id;
            }
            finally
            {
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        //Método que sirve para ejecutar consultas que regresan un valor, por ejemplo el insert
        public static int ExecuteNonQuery(string sp, params object[] parametros)
        {
            int IdOrigenDestino = 0;

            //Obtener la cadena de conexión
            string cadenaConexion = Configuracion.CadenaConexion;

            //Crear la conexión
            SqlConnection conn = new SqlConnection(cadenaConexion);

            try
            {
                //verificar que la conexion no esté abierta
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
                else
                {
                    //Crear el SqlCommand
                    SqlCommand cmd = new SqlCommand(sp, conn);

                    //Se selecciona el tipo de comando y se envía el nombre del storedProocedure
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = sp;
                    //Agregan los parámetros
                    for (int i = 0; i < parametros.Length; i = i + 2)
                    {
                        cmd.Parameters.AddWithValue(parametros[i].ToString(), parametros[i + 1]);
                    }
                    conn.Open();

                    cmd.ExecuteNonQuery();

                    IdOrigenDestino = 1;

                    conn.Close();
                }
                return IdOrigenDestino;
            }
            catch (Exception ex)
            {
                return IdOrigenDestino;
            }
            finally
            { //verificar que la conexion no esté abierta
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }
    }
}

