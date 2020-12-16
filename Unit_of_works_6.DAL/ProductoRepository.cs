using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unit_of_works_6.EE;
using Dapper;

namespace Unit_of_works_6.DAL
{
    public class ProductoRepository : IProductoRepository
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["ORDENDB"].ConnectionString;

        public IEnumerable<Producto> Listar()
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                string query = "select * from Producto";
                return sqlConnection.Query<Producto>(query);
            }    
        }
    }
}
