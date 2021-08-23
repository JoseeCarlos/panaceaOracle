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
    public class ConfigImpl : ConfigDao
    {
        public DataTable Get()
        {
            string query = "SELECT pathFotoUsuario,pathFotoProducto FROM Configuracion";
            try
            {


                SqlDataAdapter adapter = DBImplementation.executeselect(DBImplementation.CreateBasicCommad(query));
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;


            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
