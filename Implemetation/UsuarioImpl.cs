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
    public class UsuarioImpl : UsuarioDao
    {
        public int delete(Usuario t)
        {
            string query = "UPDATE usuario SET estado=0 ,UsuarioId=@UsuarioId,fechaActualizacion=CURRENT_TIMESTAMP WHERE idUsuario = @idUsuario";


            try
            {
                System.Diagnostics.Debug.WriteLine(string.Format("{0} Info:Iniciando el Delete en UsuarioModel", DateTime.Now));

                SqlCommand cmd = DBImplementation.CreateBasicCommad(query);
               
                cmd.Parameters.AddWithValue("@UsuarioId", t.UserId);
                cmd.Parameters.AddWithValue("@idUsuario", t.IdUsuario);



                int res= DBImplementation.ExecuteBasicCommand(cmd);
                if (res>0)
                {
                    System.Diagnostics.Debug.WriteLine(string.Format("{0} Info:Eliminacion de Usuario Exitoso, {1} Id Usuario que realizo la Operacion ", DateTime.Now, Session.SessionId));
                }
                else
                {

                }
                return res;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(string.Format("{0} Info: Error, {1} Id Usuario,{2}Exeption: ", DateTime.Now, Session.SessionId,ex.Message));
                throw ex;
            }
        }

        public Usuario get(int id)
        {
            Usuario a = null;
            string query = @"SELECT idUsuario,nombre,primerApellido,segundoApellido,fechaNacimiento,genero,email,role,fechaActualizacion,UsuarioId
                       FROM usuario
                       WHERE idUsuario=@idUsuario ";

            System.Diagnostics.Debug.WriteLine(string.Format("{0} Info: Inicio del GetFull en UsuarioModel, {1} Id Usuario", DateTime.Now, Session.SessionId));
            SqlDataReader dr = null;
            SqlCommand cmd = null;
            try
            {

                cmd = DBImplementation.CreateBasicCommad(query);
                cmd.Parameters.AddWithValue("@idUsuario", id);
                dr = DBImplementation.ExecuteDataReaderCommand(cmd);
                while (dr.Read())
                {
                    a = new Usuario(int.Parse(dr[0].ToString()), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(),DateTime.Parse(dr[4].ToString()), dr[5].ToString(), dr[6].ToString(), dr[7].ToString(),DateTime.Parse(dr[8].ToString()),int.Parse(dr[9].ToString()));
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(string.Format("{0} Info: Error en Metodo GetFull UsuarioModel, {1} Id Usuario,{2} Exception", DateTime.Now, Session.SessionId,ex.Message));
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
               return DBImplementation.GetIdentityFromTable("usuario");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public int insert(Usuario t)
        {
            string query = "INSERT INTO usuario(nombre,primerApellido,segundoApellido,fechaNacimiento,genero,email,nombreUsuario,password,role,UsuarioId,fechaActualizacion,foto) " +
                "VALUES(@nombre, @primerApellido, @segundoApellido, @fechaNacimiento, @genero, @email, @nombreUsusario, HASHBYTES('md5', @password), @role, @UsuarioId,CURRENT_TIMESTAMP,@foto); ";


            try
            {
                System.Diagnostics.Debug.WriteLine(string.Format("{0} Info:Iniciando el metodo insert en UsuarioMoel", DateTime.Now));

               

                SqlCommand cmd = DBImplementation.CreateBasicCommad(query);
                cmd.Parameters.AddWithValue("@nombre", t.Nombre);
                cmd.Parameters.AddWithValue("@primerApellido", t.PriApellido);
                cmd.Parameters.AddWithValue("@segundoApellido", t.SeguApellido);
                cmd.Parameters.AddWithValue("@fechaNacimiento", t.FechaNacimiento);
                cmd.Parameters.AddWithValue("@genero", t.Genero);
                cmd.Parameters.AddWithValue("@email", t.Email);
                cmd.Parameters.AddWithValue("@nombreUsusario", t.NombreUsuario);
                cmd.Parameters.AddWithValue("@password", t.Password).SqlDbType = SqlDbType.VarChar;
                cmd.Parameters.AddWithValue("@role", t.Role);
                cmd.Parameters.AddWithValue("@UsuarioId", t.UserId);
                cmd.Parameters.AddWithValue("@foto", t.Foto);


                int res = DBImplementation.ExecuteBasicCommand(cmd);
                if (res>0)
                {
                    System.Diagnostics.Debug.WriteLine(string.Format("{0} Info:Iniciando el metodo insert en UsuarioMoel", DateTime.Now));
                }
                return res;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(string.Format("{0} Info:Error,{1}Consulta,{2} Exception,{3}Id Usuario.", DateTime.Now,query,ex.Message,Session.SessionId));
                throw ex;
                
            }
        }

        public DataTable Login(string nombreUsuario, string password)
        {
            string query = "SELECT idUsuario,nombreUsuario,password,role,primerInicio,foto FROM usuario WHERE estado = 1 AND nombreUsuario = @nombreUsuario AND password = HASHBYTES('md5', @password)";
            try
            {
                System.Diagnostics.Debug.WriteLine(string.Format("{0} Info:Iniciando el metodo Login ", DateTime.Now));
                DataTable dt;
                SqlCommand cmd = DBImplementation.CreateBasicCommad(query);
                cmd.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);
                cmd.Parameters.AddWithValue("@password", password).SqlDbType=SqlDbType.VarChar;
                SqlDataAdapter adapter = DBImplementation.executeselect(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dt=table;
                if (dt.Rows.Count > 0)
                {
                    System.Diagnostics.Debug.WriteLine(string.Format("{0} Info:Inicio de Session Correcto, {1} Id Usuario que intento Ingresar", DateTime.Now,dt.Rows[0][0].ToString()));
                }
                else
                {
                    System.Diagnostics.Debug.WriteLine(string.Format("{0} Info:Inicio de Session Incorrecto, {1}  Usuario y Cotraseña Utilizados ", DateTime.Now,nombreUsuario+" y "+password));
                }
                return dt;


            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(string.Format("{0} Info:Error , {1} Exception,{2} Consulta ", DateTime.Now, ex.Message,query));
                throw;
            }
        }

        public DataTable select()
        {
            string query = "SELECT * FROM vwUsuarios";
            try
            {
                System.Diagnostics.Debug.WriteLine(string.Format("{0} Info:Iniciando el Select en Usuario Model", DateTime.Now));

                SqlDataAdapter adapter = DBImplementation.executeselect(DBImplementation.CreateBasicCommad(query));
                DataTable table = new DataTable();
                adapter.Fill(table);

                DataTable res = table;

                if (res.Rows.Count>0)
                {
                    System.Diagnostics.Debug.WriteLine(string.Format("{0} Info:Select correcto sobre UsuarioModel,{1} Id del Usuario ", DateTime.Now,Session.SessionId));
                }
                else
                {
                    System.Diagnostics.Debug.WriteLine(string.Format("{0} Info:Select incorrecto sobre UsuarioModel,{1} Id del Usuario ", DateTime.Now, Session.SessionId));
                }
                return table;


            }
            catch (Exception)
            {
                System.Diagnostics.Debug.WriteLine(string.Format("{0} Info:Select incorrecto sobre UsuarioModel,{1} Id del Usuario ", DateTime.Now, Session.SessionId));
                throw;
            }
        }

        public DataTable selectUsername(string username)
        {
            string query = "SELECT nombreUsuario FROM usuario WHERE nombreUsuario = @nombreUsuario";
            try
            {
                try
                {

                    SqlCommand cmd = DBImplementation.CreateBasicCommad(query);
                    cmd.Parameters.AddWithValue("@nombreUsuario", username);

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
            catch (Exception)
            {
                System.Diagnostics.Debug.WriteLine(string.Format("{0} Info:Select incorrecto sobre UsuarioModel,{1} Id del Usuario ", DateTime.Now, Session.SessionId));
                throw;
            }
        }

        public int update(Usuario t)
        {
            string query = "UPDATE usuario SET nombre=@nombre,primerApellido=@primerApellido,segundoApellido=@segundoApellido,fechaNacimiento=@fechaNacimiento,genero=@genero,email=@email,role=@role,fechaActualizacion=CURRENT_TIMESTAMP,UsuarioId=@UsuarioId WHERE idUsuario = @idUsuario";


            try
            {
                System.Diagnostics.Debug.WriteLine(string.Format("{0} Info:Iniciando el Update en Usuario Model", DateTime.Now));

                SqlCommand cmd = DBImplementation.CreateBasicCommad(query);
                cmd.Parameters.AddWithValue("@nombre", t.Nombre);
                cmd.Parameters.AddWithValue("@primerApellido", t.PriApellido);
                cmd.Parameters.AddWithValue("@segundoApellido", t.SeguApellido);
                cmd.Parameters.AddWithValue("@fechaNacimiento", t.FechaNacimiento);
                cmd.Parameters.AddWithValue("@genero", t.Genero);
                cmd.Parameters.AddWithValue("@email", t.Email);
                cmd.Parameters.AddWithValue("@role", t.Role);
                cmd.Parameters.AddWithValue("@UsuarioId", t.UserId);
                cmd.Parameters.AddWithValue("@idUsuario", t.IdUsuario);

                int res = DBImplementation.ExecuteBasicCommand(cmd);

                if (res>0)
                {
                    System.Diagnostics.Debug.WriteLine(string.Format("{0} Info: Modificacion Exitosa,{1} id del Usuario", DateTime.Now,Session.SessionId));
                }
                else
                {
                    System.Diagnostics.Debug.WriteLine(string.Format("{0} Info:Modificacion no realizada,{1} Id del Usuario", DateTime.Now,Session.SessionId));
                }

                return res;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(string.Format("{0} Info:Update incorrecto sobre UsuarioModel,{1} Id del Usuario,{2}Exception. ", DateTime.Now, Session.SessionId,ex.Message));
                throw ex;
            }
        }

        public int updatePasseord2(int usuarioid, Usuario u, string pas)
        {
            string query = "UPDATE usuario SET password=HASHBYTES('md5',@password)  WHERE idUsuario=@idUsuario AND password=HASHBYTES('md5', @prepas)";
            try
            {
                System.Diagnostics.Debug.WriteLine(string.Format("{0} Info:Iniciando el metodo Cambio de Password en Usuario Model", DateTime.Now));

                SqlCommand cmd = DBImplementation.CreateBasicCommad(query);
                cmd.Parameters.AddWithValue("@idUsuario", usuarioid);
                cmd.Parameters.AddWithValue("@password", u.Password).SqlDbType = SqlDbType.VarChar;
                cmd.Parameters.AddWithValue("@prepas",pas).SqlDbType = SqlDbType.VarChar;

                int res = DBImplementation.ExecuteBasicCommand(cmd);

                if (res>0)
                {
                    System.Diagnostics.Debug.WriteLine(string.Format("{0} Info:Cambio de password correcto ,{1}Id del usuario que cambio la contraseña", DateTime.Now,Session.SessionId));
                }
                else
                {
                    System.Diagnostics.Debug.WriteLine(string.Format("{0} Info:Cambio de password incorrecto ,{1}Id del usuario que intento cambiar la contraseña", DateTime.Now, Session.SessionId));
                }
                return res;

            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(string.Format("{0} Info: Error,{1} Id del Usuario,{2}Exception.,{3} Query", DateTime.Now, Session.SessionId, ex.Message,query));
                throw ex;
            }
        }

        public int updatePassword(int usuarioid, Usuario u)
        {
            string query = "UPDATE usuario SET password=HASHBYTES('md5',@password), primerInicio=@primerInicio  WHERE idUsuario=@idUsuario";
            try
            {
                System.Diagnostics.Debug.WriteLine(string.Format("{0} Info:Iniciando el metodo Cambio de de Password al Primer Inicio de session en Usuario Model", DateTime.Now));

                SqlCommand cmd = DBImplementation.CreateBasicCommad(query);
                cmd.Parameters.AddWithValue("@idUsuario", usuarioid);
                cmd.Parameters.AddWithValue("@password", u.Password).SqlDbType = SqlDbType.VarChar;
                cmd.Parameters.AddWithValue("@primerInicio", u.PrimerInicio);

                int res= DBImplementation.ExecuteBasicCommand(cmd);
                if (res>0)
                {
                    System.Diagnostics.Debug.WriteLine(string.Format("{0} Info:Cambio de password correcto ,{1}Id del usuario que cambio la contraseña", DateTime.Now, Session.SessionId));
                }
                else
                {
                    System.Diagnostics.Debug.WriteLine(string.Format("{0} Info:Cambio de password incorrecto ,{1}Id del usuario que intento cambiar la contraseña", DateTime.Now, Session.SessionId));
                }
                return res;
                   
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(string.Format("{0} Info: Error,{1} Id del Usuario,{2}Exception.,{3} Query", DateTime.Now, Session.SessionId, ex.Message, query));
                throw ex;
            }
        }

        public int updateRecuperarPass(string email, string nomuser, Usuario u)
        {
            string query = "UPDATE usuario SET password=HASHBYTES('md5',@password), primerInicio=@primerInicio  WHERE email=@email AND nombreUsuario=@nombreUsusario";
            try
            {
                System.Diagnostics.Debug.WriteLine(string.Format("{0} Info:Iniciando el metodo Cambio de Recuperacion de Password al Primer Inicio de session en Usuario Model", DateTime.Now));

                SqlCommand cmd = DBImplementation.CreateBasicCommad(query);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@nombreUsusario", nomuser);
                cmd.Parameters.AddWithValue("@password", u.Password).SqlDbType = SqlDbType.VarChar;
                cmd.Parameters.AddWithValue("@primerInicio", u.PrimerInicio);

                int res= DBImplementation.ExecuteBasicCommand(cmd);
                if (res>0)
                {
                    System.Diagnostics.Debug.WriteLine(string.Format("{0} Info:Recuperacion  de password correcto ,{1}Correo del Usuario", DateTime.Now,email ));
                }
                else
                {
                    System.Diagnostics.Debug.WriteLine(string.Format("{0} Info:Recuperacion  de password incorrecto ,{1}Correo del Usuario", DateTime.Now, email));
                }
                return res;

            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(string.Format("{0} Info: Error,{1} ,{1}Exception.,{2} Query", DateTime.Now, ex.Message, query));
                throw ex;
            }
        }
    }
}
