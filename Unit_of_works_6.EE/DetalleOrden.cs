using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_of_works_6.EE
{
    public class DetalleOrden
    {
        public int Id { get; set; }
        public int Producto_id { get; set; }
        public int Orden_id { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
    }
}
