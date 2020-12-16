using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unit_of_works_6.BLL;
using Unit_of_works_6.EE;

namespace Unit_of_works_6
{
    public partial class Form1 : Form
    {
        private ProductoBLL productoBLL = new ProductoBLL();
        private List<DetalleOrden> detalleOrdenList = new List<DetalleOrden>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_agregar_producto_Click(object sender, EventArgs e)
        {
            Producto producto = SeleccionarIdProducto();

            DetalleOrden detalleOrden = new DetalleOrden
            {
                Cantidad = Convert.ToInt32(num_cantidad_compra.Value),
                Precio = producto.Precio_unitario,
                Producto_id = producto.Id
            };

            detalleOrdenList.Add(detalleOrden);
            RefrescarGrilla();

        }

        private void RefrescarGrilla()
        {
            grillaCompra.DataSource = null;
            grillaCompra.DataSource = detalleOrdenList.ToList();
        }

        private Producto SeleccionarIdProducto()
        {
            int producto_id = Convert.ToInt32(txt_producto_id_compra.Text);
            return productoBLL.BuscarProductoporId(producto_id);
        }
    }
}
