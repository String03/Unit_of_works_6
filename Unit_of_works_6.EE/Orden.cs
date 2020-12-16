using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_of_works_6.EE
{
    public class Orden
    {
        public int Id { get; set; }
        public DateTime Fecha_reg { get; set; }
        public List<DetalleOrden> DetalleOrdenList { get; set; } = new List<DetalleOrden>();
    }
}
