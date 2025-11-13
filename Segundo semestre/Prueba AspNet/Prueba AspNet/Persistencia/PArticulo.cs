using Prueba_AspNet.Dominio;
using System.Data;

namespace Prueba_AspNet.Persistencia
{
    public class PArticulo
    {
        private Conexion Conexion = new Conexion();

        public List<Articulo> ListaArticulos()
        {
            string sql = "SELECT * FROM Articulo";

            DataSet datos = Conexion.Consulta(sql);

            List<Articulo> lista = new List<Articulo>();

            foreach (DataRow fila in datos.Tables[0].Rows)
            {
                Articulo unArticulo = new Articulo(
                    int.Parse(fila[0].ToString()),    //ID
                    fila[1].ToString(),               //Nombre
                    fila[2].ToString(),               //Rubro
                    double.Parse(fila[3].ToString()), //Precio
                    int.Parse(fila[4].ToString())     //Stock
                    );
                lista.Add(unArticulo);
            }
            return lista;
        }

        public bool Alta(Articulo unArticulo)
        {
            string precio = unArticulo.Precio.ToString().Replace(",", ".");
            string sql = $"INSERT INTO Articulo (id, nombre, rubro, precio, stock) VALUES ('{unArticulo.Id}'" +
                $", '{unArticulo.Nombre}', '{unArticulo.Rubro}', '{precio}', '{unArticulo.Stock}')";

            return Conexion.Ejecutar(sql);
        }
        public bool Baja(int pId)
        {
            string sql = "DELETE FROM Articulo WHERE id = " + pId.ToString();

            return Conexion.Ejecutar(sql);
        }
        public bool Modificar(Articulo unArticulo)
        {
            string sql = "UPDATE Articulo "
                + "SET nombre = '" + unArticulo.Nombre + "',"
                + "rubro = '" + unArticulo.Rubro + "',"
                + "precio = '" + unArticulo.Precio + "',"
                + "stock = '" + unArticulo.Stock + "' "
                + "WHERE id = " + unArticulo.Id.ToString();

            return Conexion.Ejecutar(sql);
        }
        public int ProximoId()
        {
            string sql = "SELECT (ISNULL(MAX(id),0)+1) FROM Articulo";
            DataSet datos = Conexion.Consulta(sql);
            DataRowCollection filas = datos.Tables[0].Rows;
            var campo = filas[0];
            int Id = int.Parse(campo[0].ToString());
            return Id;
        }
    }
}
