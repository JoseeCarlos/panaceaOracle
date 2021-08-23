using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Implemetation
{
    class DBImplementation
    {
        static string connectionString = "data source = localhost; initial catalog = bdpanacea; user id = sa; password = Univalle";

        #region Command Create
        public static SqlCommand CreateBasicCommad()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            return cmd;
        }

        public static List<SqlCommand> CreateNBasicCommand(int n)
        {
            List<SqlCommand> res = new List<SqlCommand>();
            SqlConnection connection = new SqlConnection(connectionString);

            for (int i = 0; i < n; i++)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                res.Add(cmd);
            }


            return res;
        }




        public static SqlCommand CreateBasicCommad(string query)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = query;
            cmd.Connection = connection;
            return cmd;
        }
        #endregion

        #region Commad Execute

        public static int ExecuteBasicCommand(SqlCommand cmd)
        {
            try
            {
                cmd.Connection.Open();
                return cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                cmd.Connection.Close();
            }
        }


        public static void ExecuteNBasicCommand(List<SqlCommand> cmds)
        {
            SqlTransaction tran= null;
            SqlCommand cmd1 = cmds[0];
            try
            {

                cmd1.Connection.Open();
                tran = cmd1.Connection.BeginTransaction();

                foreach ( SqlCommand item in cmds)
                {
                    item.Transaction = tran;
                    item.ExecuteNonQuery();
                }

                tran.Commit();
            }
            catch (Exception ex)
            {
                tran.Rollback();
                throw ex;
            }
            finally
            {
                cmd1.Connection.Close();
            }
        }

        public static string ExecuteScalarCommand(SqlCommand cmd)
        {
            try
            {
                cmd.Connection.Open();
                return cmd.ExecuteScalar().ToString();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                cmd.Connection.Close();
            }
        }


        public static int GetIdentityFromTable (string tabla)
        {
            string query = "SELECT IDENT_CURRENT('"+tabla+"')+ IDENT_INCR('"+tabla+"')";
            try
            {
                SqlCommand cmd = CreateBasicCommad(query);
               return int.Parse(ExecuteScalarCommand(cmd));
               
            }
            catch (Exception ex)
            {

                throw ex;
            }
           
        }

        public static SqlDataAdapter executeselect( SqlCommand cmd)
        {
            try
            {
                cmd.Connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                return adapter;
                

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                cmd.Connection.Close();
            }
        }
        /// <summary>
        /// OJO NO SE SIERA LA CONEXION. SE DEBE CERRAR AL LLAMAR EL METODO
        /// </summary>
        /// <param name="cmd"></param>
        /// <returns></returns>

        public static SqlDataReader ExecuteDataReaderCommand( SqlCommand cmd)
        {
            SqlDataReader dr = null;
            try
            {
                cmd.Connection.Open();
                dr=cmd.ExecuteReader();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return dr;
        }
       


        #endregion
    }
}
