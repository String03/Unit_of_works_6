using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_of_works_6.EE
{
    public class Producto
    {
        public int Id { get; set; }
        public decimal Precio_unitario { get; set; }
        public string Nombre { get; set; }
        public int Cantidad_stock { get; set; }
    }
}
