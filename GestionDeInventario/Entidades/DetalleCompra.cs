using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeInventario.Entidades
{
    public class DetalleCompra
    {
        public int CodigoComprasProducto { get; set; }
        public int CodigoDeProducto { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public float Costo { get; set; }
        public DateTime FechaDeVencimineto { get; set; }

        public DetalleCompra()
        {
            CodigoComprasProducto = 0;
            CodigoDeProducto = 0;
            Descripcion = string.Empty;
            Cantidad = 0;
            Costo = 0;
            FechaDeVencimineto = DateTime.Now;

        }
    }
}
