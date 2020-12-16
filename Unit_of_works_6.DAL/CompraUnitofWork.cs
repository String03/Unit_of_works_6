using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unit_of_works_6.EE;

namespace Unit_of_works_6.DAL
{
    public class CompraUnitofWork : ICompraUnitofWork
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["ORDENDB"].ConnectionString;

        public void RealizarCompra(Orden orden)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();

                using (SqlTransaction sqlTransaction = sqlConnection.BeginTransaction())
                {
                    try
                    {
                        string queryInsertarOrden = CrearQueryInsertarOrden();
                        SqlCommand sqlCommand = new SqlCommand(queryInsertarOrden,sqlConnection,sqlTransaction);
                        sqlCommand.Parameters.AddRange(CrearParametrosInsertarOrden(sqlCommand,orden));
                        int orden_id = Convert.ToInt32(sqlCommand.ExecuteScalar());

                        foreach (var detalleOrden in orden.DetalleOrdenList)
                        {
                            detalleOrden.Orden_id = orden_id;
                            string queryInsertarDetalleOrden = CrearQueryInsertarDetalleOrden();
                            SqlCommand sqlCommand2 = new SqlCommand(queryInsertarDetalleOrden, sqlConnection, sqlTransaction);
                            sqlCommand2.Parameters.AddRange(CrearParametrosInsertarDetalleOrden(sqlCommand2,detalleOrden));
                            sqlCommand2.ExecuteNonQuery();
                        }



                        sqlTransaction.Commit();
                    }
                    catch (Exception ex)
                    {

                        sqlTransaction.Rollback();
                    }


                }


            }
        }

        private SqlParameter[] CrearParametrosInsertarDetalleOrden(SqlCommand sqlCommand2, DetalleOrden detalleOrden)
        {
            List<SqlParameter> sqlParameters = new List<SqlParameter>();

            var p1 = sqlCommand2.CreateParameter();
            p1.ParameterName = "producto_id";
            p1.Value = detalleOrden.Producto_id;

            sqlParameters.Add(p1);

            var p2 = sqlCommand2.CreateParameter();
            p2.ParameterName = "orden_id";
            p2.Value = detalleOrden.Orden_id;

            sqlParameters.Add(p2);

            var p3 = sqlCommand2.CreateParameter();
            p3.ParameterName = "cantidad";
            p3.Value = detalleOrden.Cantidad;

            sqlParameters.Add(p3);

            var p4 = sqlCommand2.CreateParameter();
            p4.ParameterName = "precio";
            p4.Value = detalleOrden.Precio;

            sqlParameters.Add(p4);


            return sqlParameters.ToArray();

        }

        private string CrearQueryInsertarDetalleOrden()
        {
            string query = @"INSERT INTO [dbo].[DetalleOrden]
               ([producto_id]
               ,[orden_id]
               ,[cantidad]
               ,[precio])
         VALUES
               (@producto_id
               ,@orden_id
               ,@cantidad
               ,@precio)";
            return query;
        }

        private SqlParameter[] CrearParametrosInsertarOrden(SqlCommand sqlCommand, Orden orden)
        {
            List<SqlParameter> sqlParameters = new List<SqlParameter>();

            var p1 = sqlCommand.CreateParameter();
            p1.ParameterName = "fecha_reg";
            p1.Value = orden.Fecha_reg;

            sqlParameters.Add(p1);

            return sqlParameters.ToArray();

        }

        private string CrearQueryInsertarOrden()
        {
            string query = @"INSERT INTO [dbo].[Orden]
               ([fecha_reg])
        OUTPUT INSERTED.ID
         VALUES
               (@fecha_reg)";
            return query;
        }
    }
}
