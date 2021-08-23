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
    public class CiudadImpl : CiudadDao
    {
        public int delete(Ciudad t)
        {
            throw new NotImplementedException();
        }

        public int insert(Ciudad t)
        {
            throw new NotImplementedException();
        }

        public DataTable select()
        {
            throw new NotImplementedException();
        }

        public DataTable selectciudadname(int id)
        {
            string query = @"SELECT idciudad,nombreCiudad FROM ciudad WHERE idciudad=@idciudad";
            try
            {

                SqlCommand cmd = DBImplementation.CreateBasicCommad(query);
                cmd.Parameters.AddWithValue("@idciudad", id);

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

        public DataTable selectnameyid( int id)
        {

            string query = @"SELECT idciudad,nombreCiudad FROM ciudad WHERE estado=1 AND idpais=@idpais";
            try
            {

                SqlCommand cmd = DBImplementation.CreateBasicCommad(query);
                cmd.Parameters.AddWithValue("@idpais", id);
              
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

        public int update(Ciudad t)
        {
            throw new NotImplementedException();
        }
    }
}
