using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Compra
    {
        public int IdCompra { get; set; }
        public int IdCliente { get; set; }
        public int IdUsuario { get; set; }
        public DateTime Fecha { get; set; }
        public double Total { get; set; }
        public byte Estado { get; set; }
        public DateTime FechachaRegistro { get; set; }
        public DateTime FechaActualizacion { get; set; }

        public byte Habilitado { get; set; }
        public Compra()
        {

        }

        public Compra(int idCompra, int idCliente, int idUsuario, DateTime fecha, double total, byte estado, DateTime fechachaRegistro, DateTime fechaActualizacion,byte habilitado)
        {
            this.IdCompra = idCompra;
            this.IdCliente = idCliente;
            this.IdUsuario = idUsuario;
            this.Fecha = fecha;
            this.Total = total;
            this.Estado = estado;
            this.FechachaRegistro = fechachaRegistro;
            this.FechaActualizacion = fechaActualizacion;
            this.Habilitado = habilitado;
        }

        public Compra(int idcliente,int idusuario,DateTime fecha,double total)
        {
            this.IdCliente = idcliente;
            this.IdUsuario = idusuario;
            this.Fecha = fecha;
            this.Total = total;

        }

        public Compra(int idcompra)
        {
            this.IdCompra = idcompra;
            
        }
    }
}
