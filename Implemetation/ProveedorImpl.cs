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
    public class ProveedorImpl : ProveedorDao
    {
        public int delete(Proveedor t)
        {
            string query = "UPDATE proveedor SET estado=0 ,usuarioId=@usuarioId,fechaActualizacion=CURRENT_TIMESTAMP WHERE idProveedor = @idProveedor";


            try
            {
                System.Diagnostics.Debug.WriteLine(string.Format("{0} Info:Iniciando el metodo Deshabilitar en Proveedor", DateTime.Now));

                SqlCommand cmd = DBImplementation.CreateBasicCommad(query);

                cmd.Parameters.AddWithValue("@idProveedor", t.Idproveedor);
                cmd.Parameters.AddWithValue("@usuarioId", t.UsuarioId);



                int res= DBImplementation.ExecuteBasicCommand(cmd);
                System.Diagnostics.Debug.WriteLine(string.Format("{0} Info:Eliminacion Exitosa en provedorModel,Objeto {1},user Id: {2}", DateTime.Now, t.VIEWINFO(), Session.SessionId));
                return res;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(string.Format("{0} Error: {1},Objeto Enviado: {2}, User ID: {3}", DateTime.Now, ex.Message, t.VIEWINFO(), Session.SessionId));
                throw ex;
            }
        }

        public Proveedor get(int id)
        {
            Proveedor a = null;
            string query = @"SELECT idProveedor,nombreProveedor,telefono,direccion,latitud,longitud,idCiudad,usuarioId 
                          FROM proveedor
                          WHERE idProveedor=@idProveedor ";


            SqlDataReader dr = null;
            SqlCommand cmd = null;
            try
            {
                cmd = DBImplementation.CreateBasicCommad(query);
                cmd.Parameters.AddWithValue("@idProveedor", id);
                dr = DBImplementation.ExecuteDataReaderCommand(cmd);
                while (dr.Read())
                {
                    a = new Proveedor(int.Parse(dr[0].ToString()), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(),double.Parse(dr[4].ToString()),double.Parse(dr[5].ToString()),int.Parse(dr[6].ToString()),int.Parse(dr[7].ToString()));
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

        public int insert(Proveedor t)
        {
            string query = "INSERT INTO proveedor(nombreProveedor,telefono,direccion,latitud,longitud,idCiudad,usuarioId) " +
                      "VALUES(@nombreProveedor, @telefono, @direccion, @latitud, @longitud, @idCiudad, @usuarioId)";


            try
            {

                System.Diagnostics.Debug.WriteLine(string.Format("{0} Info:Iniciando el metodo insert en Proveedor", DateTime.Now));

                SqlCommand cmd = DBImplementation.CreateBasicCommad(query);
                cmd.Parameters.AddWithValue("@nombreProveedor", t.Nombreproveedor);
                cmd.Parameters.AddWithValue("@telefono", t.Telefono);
                cmd.Parameters.AddWithValue("@direccion", t.Direccion);
                cmd.Parameters.AddWithValue("@latitud", t.Latitud);
                cmd.Parameters.AddWithValue("@longitud", t.Longitud);
                cmd.Parameters.AddWithValue("@idCiudad", t.Idciudad);
                cmd.Parameters.AddWithValue("@usuarioId", t.UsuarioId);
               



                int res= DBImplementation.ExecuteBasicCommand(cmd);
                System.Diagnostics.Debug.WriteLine(string.Format("{0} Info:Insercion Exitosa en provedorModel,Objeto {1},user Id: {2}", DateTime.Now,t.VIEWINFO(),Session.SessionId));
                return res;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(string.Format("{0} Error: {1},Objeto Enviado: {2}, User ID: {3}", DateTime.Now,ex.Message,t.VIEWINFO(),Session.SessionId));
                throw ex;
            }
        }

        public DataTable select()
        {
            string query = "SELECT * FROM vwSelectProveedor";
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

        public DataTable SelectIdName()
        {
            string query = @"SELECT idProveedor,nombreProveedor FROM proveedor WHERE estado=1";
            try
            {

                SqlCommand cmd = DBImplementation.CreateBasicCommad(query);


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

        public int update(Proveedor t)
        {
            string query = "UPDATE proveedor SET nombreProveedor=@nombreProveedor,telefono=@telefono,direccion=@direccion,latitud=@latitud,longitud=@longitud,idCiudad=@idCiudad,fechaActualizacion=CURRENT_TIMESTAMP,usuarioId=@usuarioId " +
                            "WHERE idProveedor = @idProveedor";


            try
            {
                System.Diagnostics.Debug.WriteLine(string.Format("{0} Info:Iniciando el metodo Update en Proveedor", DateTime.Now));

                SqlCommand cmd = DBImplementation.CreateBasicCommad(query);
                cmd.Parameters.AddWithValue("@nombreProveedor", t.Nombreproveedor);
                cmd.Parameters.AddWithValue("@telefono", t.Telefono);
                cmd.Parameters.AddWithValue("@direccion", t.Direccion);
                cmd.Parameters.AddWithValue("@latitud", t.Latitud);
                cmd.Parameters.AddWithValue("@longitud", t.Longitud);
                cmd.Parameters.AddWithValue("@idCiudad", t.Idciudad);
                cmd.Parameters.AddWithValue("@usuarioId", t.UsuarioId);
                cmd.Parameters.AddWithValue("@idProveedor", t.Idproveedor);



                int res= DBImplementation.ExecuteBasicCommand(cmd);
                System.Diagnostics.Debug.WriteLine(string.Format("{0} Info:Incercion Exitosa en ProvedorModelObjeto {1},user Id: {2}", DateTime.Now, t.VIEWINFO(), Session.SessionId));
                return res;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
