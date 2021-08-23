using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Dao;
using System.Data;
using System.Data.SqlClient;

namespace Implemetation
{
    public class CompraImpl : CompraDao
    {
        public int delete(Compra t)
        {
            string query = @"UPDATE venta SET estado=0 WHERE Idcompra=@Idcompra";


            try
            {
                System.Diagnostics.Debug.WriteLine(string.Format("{0} Info:Iniciando el metodo delete en Venta Model", DateTime.Now));
                SqlCommand cmd = DBImplementation.CreateBasicCommad(query);
                cmd.Parameters.AddWithValue("@Idcompra", t.IdCompra);



                int res = DBImplementation.ExecuteBasicCommand(cmd);
                System.Diagnostics.Debug.WriteLine(string.Format("{0} Info:Eliminacion Exitosa en Venta Model,{1} Id de la venta", DateTime.Now,t.IdCliente));
                return res;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(string.Format("{0} Info:Error en el Metodo Update de VentaModel,{1} Exeception", DateTime.Now, ex.Message));
                throw ex;
            }
        }

        public int insert(Compra t)
        {
            throw new NotImplementedException();
        }

        public void Insert2(Compra c, List<Productos> p)
        {
            string query = "INSERT INTO venta (Idcliente,idUsuario,fecha,total,fechaActualizacion)" +
                             "VALUES(@Idcliente, @idUsuario, @fecha, @total, CURRENT_TIMESTAMP)";

            string query2 = "INSERT INTO ventaDetalle(idCompra,idProducto,cantidad,precioUnitario)" +
                              "VALUES(@idCompra, @idProducto, @cantidad, @precioUnitario)";

            

            try
            {

                System.Diagnostics.Debug.WriteLine(string.Format("{0} Info:Iniciando el metodo insert en Venta", DateTime.Now));

               List< SqlCommand> cmds = DBImplementation.CreateNBasicCommand(1+p.Count);
                int id = DBImplementation.GetIdentityFromTable("venta");

                for (int i = 0; i < cmds.Count; i++)
                {
                    if (i==0)
                    {
                        cmds[i].CommandText = query;
                        cmds[i].Parameters.AddWithValue("@Idcliente", c.IdCliente);
                        cmds[i].Parameters.AddWithValue("@idUsuario", c.IdUsuario);
                        cmds[i].Parameters.AddWithValue("@fecha", c.Fecha);
                        cmds[i].Parameters.AddWithValue("@total", c.Total);

                    }
                    else
                    {
                        cmds[i].CommandText = query2;
                        cmds[i].Parameters.AddWithValue("@idCompra",id);
                        cmds[i].Parameters.AddWithValue("@idProducto", p[i - 1].IdProducto);
                        cmds[i].Parameters.AddWithValue("@cantidad", p[i - 1].Cantidad);
                        cmds[i].Parameters.AddWithValue("@precioUnitario", p[i - 1].Precio);

                       

                    }
                }






                System.Diagnostics.Debug.WriteLine(string.Format("{0} Info:Venta Exitosa Realizada,{1}id de venta", DateTime.Now,c.IdCompra));
                DBImplementation.ExecuteNBasicCommand(cmds);
              
               
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(string.Format("{0} Info:Error en el Metodo venta ,{1} Exception", DateTime.Now,ex.Message));
                throw ex;
            }
        }

        public DataTable select()
        {
            string query = "SELECT C.Idcompra,CL.nombre,U.nombre,C.fecha,total,D.cantidad,D.precioUnitario FROM venta C INNER JOIN ventaDetalle D ON D.idCompra = C.Idcompra INNER JOIN Cliente CL ON CL.IdCliente = C.Idcliente INNER JOIN usuario U ON U.idUsuario = C.idUsuario WHERE C.habilitado=1 AND C.estado=1";
            try
            {
                System.Diagnostics.Debug.WriteLine(string.Format("{0} Info:Iniciando el metodo Select en Venta", DateTime.Now));


                SqlDataAdapter adapter = DBImplementation.executeselect(DBImplementation.CreateBasicCommad(query));
                DataTable table = new DataTable();
                adapter.Fill(table);

                return table;


            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(string.Format("{0} Error: {1}, User ID: {2}", DateTime.Now, ex.Message, Session.SessionId));
                throw ex;
            }
        }

        public DataTable selectDadoBaja()
        {
            string query = "SELECT C.Idcompra,CL.nombre,U.nombre,C.fecha,total,D.cantidad,D.precioUnitario FROM venta C INNER JOIN ventaDetalle D ON D.idCompra = C.Idcompra INNER JOIN Cliente CL ON CL.IdCliente = C.Idcliente INNER JOIN usuario U ON U.idUsuario = C.idUsuario WHERE C.estado=0";
            try
            {
                System.Diagnostics.Debug.WriteLine(string.Format("{0} Info:Iniciando el metodo Select en Proveedor", DateTime.Now));


                SqlDataAdapter adapter = DBImplementation.executeselect(DBImplementation.CreateBasicCommad(query));
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;


            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(string.Format("{0} Error: {1}, User ID: {2}", DateTime.Now, ex.Message, Session.SessionId));
                throw ex;
            }
        }

        public DataTable selectdelete()
        {
            string query = "SELECT C.Idcompra,CL.nombre,U.nombre,C.fecha,total,D.cantidad,D.precioUnitario FROM venta C INNER JOIN ventaDetalle D ON D.idCompra = C.Idcompra INNER JOIN Cliente CL ON CL.IdCliente = C.Idcliente INNER JOIN usuario U ON U.idUsuario = C.idUsuario WHERE C.habilitado=0";
            try
            {
                System.Diagnostics.Debug.WriteLine(string.Format("{0} Info:Iniciando el metodo Select en Proveedor", DateTime.Now));


                SqlDataAdapter adapter = DBImplementation.executeselect(DBImplementation.CreateBasicCommad(query));
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;


            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(string.Format("{0} Error: {1}, User ID: {2}", DateTime.Now, ex.Message, Session.SessionId));
                throw ex;
            }
        }

        public DataTable serachDate(string f1, string f2)
        {

            string query = @"SELECT * FROM venta WHERE fecha BETWEEN @fecha1 AND @fecha2";
            try
            {

                SqlCommand cmd = DBImplementation.CreateBasicCommad(query);
                cmd.Parameters.AddWithValue("@fecha1", f1+" "+ "00:00:00");
                cmd.Parameters.AddWithValue("@fecha2", f2+" "+ "23:59:59");

                SqlDataAdapter adapter = DBImplementation.executeselect(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;


            }
            catch (Exception)
            {

                throw;
            }
        }

        public int update(Compra t)
        {
            string query = @"UPDATE venta SET habilitado=0 WHERE Idcompra=@Idcompra";


            try
            {
                System.Diagnostics.Debug.WriteLine(string.Format("{0} Info:Iniciando el metodo Update en Venta Model", DateTime.Now));
                SqlCommand cmd = DBImplementation.CreateBasicCommad(query);
                cmd.Parameters.AddWithValue("@Idcompra", t.IdCompra);
               


                int res = DBImplementation.ExecuteBasicCommand(cmd);
                System.Diagnostics.Debug.WriteLine(string.Format("{0} Info:Anulacion Exitosa en VentaModel,{1} Id de la venta", DateTime.Now,t.IdCompra));
                return res;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(string.Format("{0} Info:Error en el Metodo Update de VentaModel  ,{1} Exeception", DateTime.Now, ex.Message));
                throw ex;
            }
        }
    }
}
