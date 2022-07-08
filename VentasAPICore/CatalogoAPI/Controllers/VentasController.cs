using BR;
using Entities;
using Microsoft.AspNetCore.Mvc;
using System.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace VentasAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VentasController : ControllerBase
    {
        VentasBR objBR = new VentasBR();
        Ventas entVentas = new Ventas();

        // GET: api/<VentasController>
        [HttpGet]
        public List<Ventas> Get()
        {
            DataTable dt = objBR.VentasCrud("LISTAR", entVentas);
            List<Ventas> list = new List<Ventas>();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(new Ventas
                {                    
                    NumeroFactura = dr["NumeroFactura"].ToString(),
                    FechaFactura = dr["FechaFactura"].ToString(),
                    Ciudad = dr["Ciudad"].ToString(),
                    Categoria = dr["Categoria"].ToString(),
                    Tienda = dr["Tienda"].ToString(),
                    Vendedor = dr["Vendedor"].ToString(),
                    IdCliente = Convert.ToInt32(dr["IdCliente"]),
                    SubTotal = Convert.ToInt32(dr["Total"]),
                    Total = Convert.ToInt32(dr["IdCliente"]),
                    Estado = Convert.ToBoolean(dr["Estado"]),
                    Modelo = dr["Modelo"].ToString(),
                    NumeroMotor = dr["NumeroMotor"].ToString(),
                    Cilindraje = dr["Cilindraje"].ToString(),
                    Color = dr["color"].ToString(),
                    Precio = Convert.ToInt32(dr["Precio"])
                    
                });
            }
            return list;
        }     
        
    }
}
