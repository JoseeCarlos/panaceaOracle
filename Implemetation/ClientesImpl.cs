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
    public class ClientesImpl : ClientesDao
    {
        public int delete(Clientes t)
        {
            throw new NotImplementedException();
        }

        public int insert(Clientes t)
        {
            string query = @"INSERT INTO Cliente(nombre,primerApellido,segundoApellido,ci,idUsuario,fechaCreacion,fechaActualizacion)" +
                "VALUES(@nombre, @primerApellido, @segundoApellido, @ci, @idUsuario,CURRENT_TIMESTAMP,CURRENT_TIMESTAMP)";


            try
            {

                System.Diagnostics.Debug.WriteLine(string.Format("{0} Info:Iniciando el metodo insert en Cliente", DateTime.Now));

                SqlCommand cmd = DBImplementation.CreateBasicCommad(query);
                cmd.Parameters.AddWithValue("@nombre", t.Nombre);
                cmd.Parameters.AddWithValue("@primerApellido", t.PrimerApellido);
                cmd.Parameters.AddWithValue("@segundoApellido", t.SegundoApellido);
                cmd.Parameters.AddWithValue("@ci", t.Ci);
                cmd.Parameters.AddWithValue("@idUsuario", t.IdUsuario);
               




                int res = DBImplementation.ExecuteBasicCommand(cmd);
                System.Diagnostics.Debug.WriteLine(string.Format("{0} Info:Cliente Registrado con Exito,{1} Datos", DateTime.Now,t.Nombre+""+t.PrimerApellido));
                return res;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(string.Format("{0} Error: {1}, User ID: {2}", DateTime.Now, ex.Message, Session.SessionId));
                throw ex;
            }
        }

        public DataTable select()
        {
            string query = "SELECT IdCliente , CONCAT(nombre,' ',primerApellido,' ',segundoApellido) AS NOMBRE,ci AS CI FROM Cliente WHERE estado=1";
            try
            {
                System.Diagnostics.Debug.WriteLine(string.Format("{0} Info:Iniciando el metodo Select en ClienteModel", DateTime.Now));


                SqlDataAdapter adapter = DBImplementation.executeselect(DBImplementation.CreateBasicCommad(query));
                DataTable table = new DataTable();
                adapter.Fill(table);
                System.Diagnostics.Debug.WriteLine(string.Format("{0} Info:Metodo Select Iniciado con Exito", DateTime.Now));
                return table;


            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(string.Format("{0} Error: {1}, User ID: {2}", DateTime.Now, ex.Message, Session.SessionId));
                throw ex;
            }
        }

        public DataTable SelectIdName(string nom)
        {
            string query = @"SELECT IdCliente,CONCAT(nombre,' ',primerApellido,' ',segundoApellido,' ',ci) nombre, ci FROM Cliente
                               WHERE nombre LIKE @nom  OR ci LIKE @nom  AND estado=1";
            try
            {

                SqlCommand cmd = DBImplementation.CreateBasicCommad(query);
                cmd.Parameters.AddWithValue("@nom", "%"+nom+"%");
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

        public int update(Clientes t)
        {
            throw new NotImplementedException();
        }
    }
}
