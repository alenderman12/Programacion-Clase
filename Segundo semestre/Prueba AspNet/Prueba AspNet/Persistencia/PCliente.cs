using System.Data;
using Prueba_AspNet.Dominio;

namespace Prueba_AspNet.Persistencia
{
    public class PCliente
    {
        private Conexion Conexion = new Conexion();

        public List<Cliente> ListaClientes()
        {
            string sql = "SELECT * FROM Cliente";

            DataSet datos = Conexion.Consulta(sql);

            List<Cliente> lista = new List<Cliente>();

            foreach (DataRow fila in datos.Tables[0].Rows)
            {
                Cliente unCliente = new Cliente( 
                    int.Parse(fila[0].ToString()), //ID
                    fila[1].ToString(),            //Nombre
                    fila[2].ToString(),            //Direccion
                    fila[3].ToString()             //Telefono
                    );
                lista.Add(unCliente);
            }
            return lista;
        }

        public bool Alta(Cliente unCliente)
        {
            string sql = "INSERT INTO cliente (id, nombre, direccion, telefono) "
                + "VALUES ("+ unCliente.Id +",'"+ unCliente.Nombre + "','" 
                + unCliente.Direccion + "','" + unCliente.Telefono + "')";

            return Conexion.Ejecutar(sql);
        }
        public bool Baja(int pId)
        {
            string sql = "DELETE FROM cliente WHERE id = " + pId.ToString();

            return Conexion.Ejecutar(sql);
        }
        public bool Modificar(Cliente unCliente)
        {
            string sql = "UPDATE cliente " 
                + "SET nombre = '" + unCliente.Nombre + "',"
                + "direccion = '" + unCliente.Direccion + "'," 
                + "telefono = '" + unCliente.Telefono + "' "
                + "WHERE id = " + unCliente.Id.ToString();

            return Conexion.Ejecutar(sql);
        }
        public int ProximoId()
        {
            string sql = "SELECT (ISNULL(MAX(id),0)+1) FROM cliente";
            DataSet datos = Conexion.Consulta(sql);
            DataRowCollection filas = datos.Tables[0].Rows;
            var campo = filas[0];
            int Id = int.Parse(campo[0].ToString());
            return Id;
        }
    }
}
