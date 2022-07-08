using DA;
using Entities;
using System.Data;

namespace BR
{
    public class VentasBR
    {        
        public DataTable VentasCrud(string Accion, Ventas entidadVentas)
        {
            try
            {
                VentasDA objRN = new VentasDA();
                return objRN.VentasCrud(Accion, entidadVentas);
            }
            catch (Exception error)
            {
                throw error;
            }
        }        
    }
}
