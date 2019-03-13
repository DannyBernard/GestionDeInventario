using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeInventario.Entidades
{
    public class DetalleIventario
    {
        public int CodigoProducto { get; set; }
        public int Cantidad { get; set; }
        public string DescripcionDelProducto { get; set; }
        public string Gondola { get; set; }
        public string Almacen { get; set; }
        public int CodigoIventario { get; set; }

        public DetalleIventario()
        {
            CodigoIventario = 0;
            Cantidad = 0;
            DescripcionDelProducto = string.Empty;
            Gondola = string.Empty;
            Almacen = string.Empty;
            CodigoIventario = 0;

        }
    }
}
