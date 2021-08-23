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
    public class EnfermedadImpl : EnfermedadesDao
    {
        public int delete(Enfermedad a)
        {
            string query = "UPDATE enfermedad SET estado=0  WHERE idEnfermedad=@idEnfermedad";

            try
            {
                SqlCommand cmd = DBImplementation.CreateBasicCommad(query);
                cmd.Parameters.AddWithValue("@idEnfermedad", a.Idenfermedad);
                return DBImplementation.ExecuteBasicCommand(cmd);

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public int insert(Enfermedad a)
        {
            string query = "INSERT INTO enfermedad(nombre,descripcion,ramaMedica,idUsuario) VALUES(@nombre, @descripcion, @ramaMedica, @idUsuario)";


            try
            {
                SqlCommand cmd = DBImplementation.CreateBasicCommad(query);
                cmd.Parameters.AddWithValue("@nombre", a.Nombre);
                cmd.Parameters.AddWithValue("@descripcion", a.Descripcion);
                cmd.Parameters.AddWithValue("@ramaMedica", a.Ramamedica);
                cmd.Parameters.AddWithValue("@idUsuario", a.Userid);

                return DBImplementation.ExecuteBasicCommand(cmd);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataTable select()
        {
            string query = "SELECT * FROM enfermedad WHERE estado=1";
            try
            {
               

                SqlDataAdapter adapter = DBImplementation.executeselect(DBImplementation.CreateBasicCommad(query));
                DataTable table =new DataTable();
                adapter.Fill(table);
                return table;


            }
            catch (Exception)
            {

                throw;
            }
            
        }

        public int update(Enfermedad a)
        {
            string query = "UPDATE enfermedad SET nombre=@nombre, descripcion=@descripcion, ramaMedica=@ramaMedica, idUsuario=@idUsuario  WHERE idEnfermedad=@idEnfermedad";
            try
            {
                SqlCommand cmd = DBImplementation.CreateBasicCommad(query);
                cmd.Parameters.AddWithValue("@idEnfermedad", a.Idenfermedad);
                cmd.Parameters.AddWithValue("@nombre", a.Nombre);
                cmd.Parameters.AddWithValue("@descripcion", a.Descripcion);
                cmd.Parameters.AddWithValue("@ramaMedica", a.Ramamedica);
                cmd.Parameters.AddWithValue("@idUsuario", a.Userid);
                return DBImplementation.ExecuteBasicCommand(cmd);

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
