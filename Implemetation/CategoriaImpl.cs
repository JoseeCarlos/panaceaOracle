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
    public class CategoriaImpl : CategoriaDao
    {
        public int delete(Categoria t)
        {
            throw new NotImplementedException();
        }

        public int insert(Categoria t)
        {
            throw new NotImplementedException();
        }

        public DataTable select()
        {
            throw new NotImplementedException();
        }

        public DataTable selectCategoriaId()
        {
            string query = @"SELECT idCategoria,nombreCategoria FROM categoria WHERE estado=1";
            try
            {
                System.Diagnostics.Debug.WriteLine(string.Format("{0} Info:Iniciando el metodo Select en CategoriaModel", DateTime.Now));
                SqlCommand cmd = DBImplementation.CreateBasicCommad(query);
              

                SqlDataAdapter adapter = DBImplementation.executeselect(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                System.Diagnostics.Debug.WriteLine(string.Format("{0} Info:Metodo Select Iniciado Con Exito", DateTime.Now));
                return table;


            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(string.Format("{0} Info:Error en el Metodo Select ,{1} Exception", DateTime.Now,ex.Message));
                throw ex;
            }
        }

        public int update(Categoria t)
        {
            throw new NotImplementedException();
        }
    }
}
