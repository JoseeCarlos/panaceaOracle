using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dao;
using Model;

namespace Implemetation
{
    public class ProductoImpl : ProductoDao
    {
        public int delete(Productos t)
        {
            throw new NotImplementedException();
        }

        public Productos Get(int id)
        {
            Productos a = null;
            string query = @"SELECT idproducto,nombreProducto,precio,descripcion,foto,stock,idCategoria,fechaVencimiento,presentacion,idUsuario,estado,fechaCreacion,fechaActualizacion,idProveedor
                             FROM producto
                             WHERE idproducto=@idproducto";
            SqlDataReader dr = null;
            SqlCommand cmd = null;
            try
            {
                cmd = DBImplementation.CreateBasicCommad(query);
                cmd.Parameters.AddWithValue("@idproducto", id);
                dr = DBImplementation.ExecuteDataReaderCommand(cmd);
                while (dr.Read())
                {
                    a = new Productos(int.Parse(dr[0].ToString()), dr[1].ToString(),double.Parse(dr[2].ToString()), dr[3].ToString(),byte.Parse(dr[4].ToString()),int.Parse(dr[5].ToString()),int.Parse(dr[6].ToString()),DateTime.Parse(dr[7].ToString()),dr[8].ToString(),int.Parse(dr[9].ToString()),byte.Parse(dr[10].ToString()),DateTime.Parse(dr[11].ToString()),DateTime.Parse(dr[12].ToString()),int.Parse(dr[13].ToString()));
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cmd.Connection.Close();
                dr.Close();
            }
            return a;
        }

        public int getIndentity()
        {
            try
            {
                return DBImplementation.GetIdentityFromTable("producto");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public int insert(Productos t)
        {
            string query = "INSERT INTO producto(nombreProducto,precio,descripcion,foto,stock,idCategoria,fechaVencimiento,presentacion,idUsuario,fechaCreacion,idProveedor,fechaActualizacion)" +
                "VALUES(@nombreProducto, @precio, @descripcion, @foto, @stock, @idCategoria, @fechaVencimiento, @presentacion, @idUsuario, CURRENT_TIMESTAMP, @idProveedor,CURRENT_TIMESTAMP)";


            try
            {
                System.Diagnostics.Debug.WriteLine(string.Format("{0} Info:Iniciando el metodo insert en Producto Model", DateTime.Now));

                SqlCommand cmd = DBImplementation.CreateBasicCommad(query);
                cmd.Parameters.AddWithValue("@nombreProducto", t.NombreProducto);
                cmd.Parameters.AddWithValue("@precio", t.Precio);
                cmd.Parameters.AddWithValue("@descripcion", t.Descripcion);
                cmd.Parameters.AddWithValue("@foto", t.Foto);
                cmd.Parameters.AddWithValue("@stock", t.Stock);
                cmd.Parameters.AddWithValue("@idCategoria", t.IdCategoria);
                cmd.Parameters.AddWithValue("@fechaVencimiento", t.FechaVencimiento);
                cmd.Parameters.AddWithValue("@presentacion", t.Presentacion).SqlDbType = SqlDbType.VarChar;
                cmd.Parameters.AddWithValue("@idUsuario", t.Idusuario);
                cmd.Parameters.AddWithValue("@idProveedor", t.Idproveedor);


                int res = DBImplementation.ExecuteBasicCommand(cmd);
                System.Diagnostics.Debug.WriteLine(string.Format("{0} Info:Producto Insertado con Exito en ProdutoModel", DateTime.Now));
                return res;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(string.Format("{0} Info:Error en Metodo Inser de ProductoModel,{1} Exeception:", DateTime.Now,ex.Message));
                throw ex;
            }
        }

        public DataTable SearchProduct(string nom)
        {
            string query = @"SELECT P.idproducto,P.nombreProducto as Producto,P.precio as Precio,P.stock as Cantidad, P.fechaVencimiento as vencimiento,C.nombreCategoria AS CATEGORIA,PR.nombreProveedor AS PROVEDOR FROM producto P
                              INNER JOIN categoria C ON C.idCategoria=P.idCategoria
                              INNER JOIN proveedor PR ON PR.idProveedor=P.idProveedor
                              WHERE C.nombreCategoria LIKE @text OR P.nombreProducto LIKE @text OR PR.nombreProveedor LIKE @text";
            try
            {

                SqlCommand cmd = DBImplementation.CreateBasicCommad(query);
                cmd.Parameters.AddWithValue("@text", "%" + nom + "%");

                SqlDataAdapter adapter = DBImplementation.executeselect(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;


            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataTable select()
        {
            throw new NotImplementedException();
        }

        public DataTable selectfoto(int id)
        {
            string query = @"SELECT foto FROM producto WHERE idproducto=@idproducto";
            try
            {

                SqlCommand cmd = DBImplementation.CreateBasicCommad(query);
                cmd.Parameters.AddWithValue("@idproducto", id);

                SqlDataAdapter adapter = DBImplementation.executeselect(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;


            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataTable SlectIdnom(int id)
        {
            string query = @"SELECT idproducto,nombreProducto,precio FROM producto WHERE idproducto=@idproducto ";
            try
            {

                SqlCommand cmd = DBImplementation.CreateBasicCommad(query);
                cmd.Parameters.AddWithValue("@idproducto", id);

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

        public int update(Productos t)
        {
            string query = "UPDATE producto SET nombreProducto=@nombreProducto, precio=@precio,descripcion=@descripcion,stock=@stock,idCategoria=@idCategoria,fechaVencimiento=@fechaVencimiento,idProveedor=@idProveedor,fechaActualizacion=CURRENT_TIMESTAMP,idUsuario=@idUsuario WHERE idproducto = @idproducto";


            try
            {
                System.Diagnostics.Debug.WriteLine(string.Format("{0} Info:Iniciando el metodo Update en Producto Model", DateTime.Now));
                SqlCommand cmd = DBImplementation.CreateBasicCommad(query);
                cmd.Parameters.AddWithValue("@nombreProducto", t.NombreProducto);
                cmd.Parameters.AddWithValue("@precio", t.Precio);
                cmd.Parameters.AddWithValue("@descripcion", t.Descripcion);
                cmd.Parameters.AddWithValue("@stock", t.Stock);
                cmd.Parameters.AddWithValue("@idCategoria", t.IdCategoria);
                cmd.Parameters.AddWithValue("@fechaVencimiento", t.FechaVencimiento);
                cmd.Parameters.AddWithValue("@idProveedor", t.Idproveedor);
                cmd.Parameters.AddWithValue("@idUsuario", Session.SessionId);
                cmd.Parameters.AddWithValue("@idproducto", t.IdProducto);


                int res= DBImplementation.ExecuteBasicCommand(cmd);
                System.Diagnostics.Debug.WriteLine(string.Format("{0} Info:Modificacion Exitosa en ProductoModel", DateTime.Now));
                return res;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(string.Format("{0} Info:Error en el Metodo Update de ProductoModel,{1} Exeception", DateTime.Now,ex.Message));
                throw ex;
            }
        }

        public void updatepro(List<Productos> producto)
        {
            string query = "UPDATE producto SET stock=stock-@stock WHERE idproducto=@idproducto";

            



            try
            {

                System.Diagnostics.Debug.WriteLine(string.Format("{0} Info:Iniciando el metodo insert en Venta", DateTime.Now));

                List<SqlCommand> cmds = DBImplementation.CreateNBasicCommand(producto.Count);
               

                for (int i = 0; i < cmds.Count; i++)
                {

                    cmds[i].CommandText = query;
                  
                    cmds[i].Parameters.AddWithValue("@idproducto", producto[i].IdProducto);
                    cmds[i].Parameters.AddWithValue("@stock", producto[i].Cantidad);
                  



                }






                System.Diagnostics.Debug.WriteLine(string.Format("{0} Info:Venta Exitosa Realizada", DateTime.Now));
                DBImplementation.ExecuteNBasicCommand(cmds);


            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(string.Format("{0} Info:Error en el Metodo venta ", DateTime.Now));
                throw ex;
            }
        }
    }
}
