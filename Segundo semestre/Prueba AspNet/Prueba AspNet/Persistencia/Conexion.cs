using Microsoft.Data.SqlClient;
using System.Data;

namespace Prueba_AspNet.Persistencia
{
    public class Conexion
    {
        private static string source = "Alex\\SQLEXPRESS";
        private static string baseDeDatos = "LosClientes";
        private string CadenaConexion = "data source="+source+"; " +
           "initial Catalog="+baseDeDatos+"; Integrated Security=SSPI; Encrypt=false";
        //private string CadenaConexion = "Data Source=localhost;User Id=sa;Password=root;Database=wonka; Connect Timeout=0";

        public bool Ejecutar(string sql)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(this.CadenaConexion);
                string FormatoFecha = "set dateformat dmy;";
                SqlCommand comando = new SqlCommand(FormatoFecha + sql, conexion);
                conexion.Open();
                comando.ExecuteNonQuery();
                comando.Dispose();
                conexion.Close();
                return true;
            }
            catch (Exception e)
            {
                throw new Exception("Error en conexión sql = " + sql + "\n", e);
            }
        }

        public DataSet Consulta(string sql)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(this.CadenaConexion);
                SqlDataAdapter adaptador = new SqlDataAdapter(sql, conexion);
                DataSet resultado = new DataSet();
                conexion.Open();
                adaptador.Fill(resultado);
                adaptador.Dispose();
                conexion.Close();
                return resultado;
            }
            catch (Exception e)
            {
                throw new Exception("Error en conexión sql = " + sql, e);
            }
        }
    }
}
