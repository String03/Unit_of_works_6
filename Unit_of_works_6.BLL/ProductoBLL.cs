using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unit_of_works_6.DAL;
using Unit_of_works_6.EE;

namespace Unit_of_works_6.BLL
{
    public class ProductoBLL
    {
        private ProductoRepository productoRepository = new ProductoRepository();

        public Producto BuscarProductoporId(int id)
        {
            return productoRepository.Listar().FirstOrDefault(p => p.Id == id);
        }

    }
}
