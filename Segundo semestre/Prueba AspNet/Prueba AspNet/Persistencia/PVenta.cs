using Prueba_AspNet.Dominio;
using System.Data;

namespace Prueba_AspNet.Persistencia
{
    public class PVenta
    {
        private Conexion Conexion = new Conexion();

        public List<Venta> ListaVentas()
        {
            string sql = "SELECT * FROM Venta";

            DataSet datos = Conexion.Consulta(sql);

            List<Venta> lista = new List<Venta>();

            foreach (DataRow fila in datos.Tables[0].Rows)
            {
                Controladora controladora = new Controladora();
                Venta unVenta = new Venta(
                    int.Parse(fila[0].ToString()),                                  //ID
                    DateTime.Parse(fila[1].ToString()),                             //Fecha
                    controladora.BuscarCliente(int.Parse(fila[2].ToString())),      //IdCliente
                    controladora.BuscarArticulo(int.Parse(fila[3].ToString())),     //IdArticulo
                    double.Parse(fila[4].ToString())                                //Importe
                    );
                lista.Add(unVenta);
            }
            return lista;
        }

        public bool Alta(Venta unVenta)
        {
            string importe = unVenta.Importe.ToString().Replace(",", ".");
            string sql = "INSERT INTO venta (id, fecha, idCliente, idArticulo, importe) "
                + "VALUES (" + unVenta.Id + ",'" + unVenta.Fecha.ToShortDateString() + "','"
                + unVenta.Cliente.Id + "','" + unVenta.Articulo.Id + "','" + importe + "');";

            return Conexion.Ejecutar(sql);
        }
        public bool Baja(int pId)
        {
            string sql = "DELETE FROM venta WHERE id = " + pId.ToString();

            return Conexion.Ejecutar(sql);
        }
        public bool Modificar(Venta unVenta)
        {
            string importe = unVenta.Importe.ToString().Replace(",", ".");
            string sql = "UPDATE venta "
                + "SET fecha = '" + unVenta.Fecha.ToShortDateString() + "',"
                + "idCliente = '" + unVenta.Cliente.Id + "',"
                + "idArticulo = '" + unVenta.Articulo.Id + "',"
                + "importe = '" + importe + "' "
                + "WHERE id = " + unVenta.Id.ToString();

            return Conexion.Ejecutar(sql);
        }
        public int ProximoId()
        {
            string sql = "SELECT (ISNULL(MAX(id),0)+1) FROM venta";
            DataSet datos = Conexion.Consulta(sql);
            DataRowCollection filas = datos.Tables[0].Rows;
            var campo = filas[0];
            int Id = int.Parse(campo[0].ToString());
            return Id;
        }
    }
}
