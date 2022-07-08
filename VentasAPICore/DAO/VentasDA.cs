using DbAccess;
using Entities;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DA
{
    public class VentasDA
    {
        // Instancia del archivo de configuración que tiene el String de conexión 
        //private SqlConnection DbProductos = new SqlConnection("cnn");
        
        // Instancia con el archivo que tiene los métodos que interactúan con la bd (DataSets, Data Tables...)
        private AccesoSQL objDatos = new AccesoSQL();
        SqlConnection con = new SqlConnection("data source=.\\DESARROLLO; initial catalog=Yamaha; user id=sa; password=123456; MultipleActiveResultSets=true");

        
        public DataTable VentasCrud(string Accion, Ventas entidadVentas)
        {
            try
            {
                DataTable dtDatos = new DataTable();
                SqlParameter[] Parametros;
                switch (Accion)
                {
                    case "INSERTAR":

                        Parametros = new SqlParameter[16];
                      
                        Parametros[0] = new SqlParameter("@NumeroFactura", entidadVentas.NumeroFactura);
                        Parametros[1] = new SqlParameter("@FechaFactura", entidadVentas.FechaFactura);
                        Parametros[2] = new SqlParameter("@Ciudad", entidadVentas.Ciudad);                        
                        Parametros[3] = new SqlParameter("@Categoria", entidadVentas.Categoria);
                        Parametros[4] = new SqlParameter("@Tienda", entidadVentas.Tienda);
                        Parametros[5] = new SqlParameter("@Vendedor", entidadVentas.Vendedor);
                        Parametros[6] = new SqlParameter("@IdCliente", entidadVentas.IdCliente);
                        Parametros[7] = new SqlParameter("@SubTotal", entidadVentas.SubTotal);
                        Parametros[8] = new SqlParameter("@Total", entidadVentas.Total);
                        Parametros[9] = new SqlParameter("@Estado", entidadVentas.Estado);
                        Parametros[10] = new SqlParameter("@Modelo", entidadVentas.Modelo);
                        Parametros[11] = new SqlParameter("@NumeroMotor", entidadVentas.NumeroMotor);
                        Parametros[12] = new SqlParameter("@Cilindraje", entidadVentas.Cilindraje);
                        Parametros[13] = new SqlParameter("@Color", entidadVentas.Color);
                        Parametros[14] = new SqlParameter("@Precio", entidadVentas.Precio);
                        Parametros[15] = new SqlParameter("@Accion", Accion);

                        break;                    


                    case "ELIMINAR":

                        Parametros = new SqlParameter[2];

                        Parametros[0] = new SqlParameter("@NumeroFactura", entidadVentas.NumeroFactura);
                        Parametros[1] = new SqlParameter("@Accion", Accion);

                        break;

                    case "CALCULO":

                        Parametros = new SqlParameter[1];

                        Parametros[0] = new SqlParameter("@Accion", Accion);

                        break;                    


                    default:
                        return null;
                }
                dtDatos = objDatos.TraerDataTable(con, "sp_Ventas_CRUD", Parametros);
                return dtDatos;

            }
            catch (Exception error)
            {
                throw error;
            }
        }        

    }
}
