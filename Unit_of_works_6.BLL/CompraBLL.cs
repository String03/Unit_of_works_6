using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unit_of_works_6.DAL;
using Unit_of_works_6.EE;

namespace Unit_of_works_6.BLL
{
    public class CompraBLL
    {
        private CompraUnitofWork compraUnitofWork = new CompraUnitofWork();


        public void RealizarCompra(Orden orden)
        {
            compraUnitofWork.RealizarCompra(orden);
        }


    }
}
