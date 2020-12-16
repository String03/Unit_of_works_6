using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unit_of_works_6.EE;

namespace Unit_of_works_6.DAL
{
    public interface ICompraUnitofWork
    {
        void RealizarCompra(Orden orden);
    }
}
