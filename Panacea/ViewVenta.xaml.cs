using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Model;
using Implemetation;
using Dao;
using System.Data;

namespace Panacea
{
    /// <summary>
    /// Lógica de interacción para ViewVenta.xaml
    /// </summary>
    public partial class ViewVenta : Window
    {
        ClientesImpl implcliente;
        ProductoImpl implproducto;
        List<Productos> products = new List<Productos>();
        int conta = 0;
        double total = 0;
        Compra compra;
        CompraImpl implcompra;
        string path;
       
        public ViewVenta()
        {
            InitializeComponent();
            
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            txtUser.Text = Session.SessionUsername;
            
        }

      

       

        private void txtProduc_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtProduc.Text.Length > 0)
            {
                implproducto = new ProductoImpl();
                dataProduct.ItemsSource = null;
                dataProduct.ItemsSource = implproducto.SearchProduct(txtProduc.Text).DefaultView;
                dataProduct.Columns[0].Visibility = Visibility.Collapsed;
            }
            else
            {
                dataProduct.ItemsSource = null;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DataRowView datarow = (DataRowView)dataProduct.SelectedItem;
            int id = int.Parse(datarow.Row.ItemArray[0].ToString());
            implproducto = new ProductoImpl();

            DataTable dt = implproducto.SlectIdnom(id);

            Productos producto = new Productos(int.Parse(dt.Rows[0][0].ToString()),dt.Rows[0][1].ToString(),double.Parse(dt.Rows[0][2].ToString()),1);

            total = total + producto.Precio;
            txtTotal.Text = total.ToString();

            foreach (var item in products)
            {
                if (item.IdProducto==id)
                {
                    conta = 1;
                }
            }
            if (conta==1)
            {
                foreach (var item in products)
                {
                    if (item.IdProducto==id)
                    {
                        item.Cantidad = item.Cantidad + 1;
                        conta = 0;
                    }
                }
            }
            else
            {
                products.Add(producto);
            }
           
          
            dtProductl.ItemsSource = null;
            dtProductl.ItemsSource = products;
        }

        private void btnVenta_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                compra = new Compra(int.Parse(comboCliente.SelectedValue.ToString()),Session.SessionId,DateTime.Now,double.Parse(txtTotal.Text));
                implcompra = new CompraImpl();
                implcompra.Insert2(compra,products);

                implproducto = new ProductoImpl();
                
                MessageBox.Show("Venta registrado con exito");
                implproducto.updatepro(products);

                products.Clear();
                 dtProductl.ItemsSource = null;
               


            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(string.Format("{0} Error: {1}, AL Realizar la Venta, ", DateTime.Now, ex.Message, 1));
                MessageBox.Show("Error Inesperado Comuniquese con el departamento de sistemas");
            }
        }

        private void dataProduct_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dataProduct.Items.Count > 0 && dataProduct.SelectedItem != null)
            {
                try
                {
                    DataRowView datarow = (DataRowView)dataProduct.SelectedItem;
                    int id = int.Parse(datarow.Row.ItemArray[0].ToString());
                    implproducto = new ProductoImpl();

                    DataTable dt = implproducto.selectfoto(id);

                    try
                    {
                        if (dt.Rows[0][0].ToString() == "1")
                        {
                            imageProduct.Source = new BitmapImage(new Uri(Config.pathFotoProducto + id + ".jpg"));
                        }
                        else
                        {
                            imageProduct.Source = new BitmapImage(new Uri(Config.pathFotoProducto + "0.jpg"));
                        }
                    }
                    catch (Exception ex)
                    {
                        System.Diagnostics.Debug.WriteLine(string.Format("{0} Error: {1}, Carga de Imagen de un producto Incorrecta, ", DateTime.Now, ex.Message, id));
                        MessageBox.Show("Error Inesperado Contacte con el departamento de sistemas");
                    }

                }
                catch (Exception ex)
                {

                    System.Diagnostics.Debug.WriteLine(string.Format("{0} Error: {1}, Carga de Imagen de un producto Incorrecta, ", DateTime.Now, ex.Message,1));
                    MessageBox.Show("Error Inesperado Contacte con el departamento de sistemas");
                }
            }
            else
            {
               
            }
        }

        private void comboCliente_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (comboCliente.Text.Length>0)
                {
                    implcliente = new ClientesImpl();
                    DataTable dt = implcliente.SelectIdName(comboCliente.Text);
                    comboCliente.SelectedValuePath = "IdCliente";
                    comboCliente.DisplayMemberPath = "nombre";
                    comboCliente.ItemsSource = dt.DefaultView;
                    if (dt.Rows.Count>0)
                    {
                        comboCliente.IsDropDownOpen = true;
                        comboCliente.SelectedItem = dt.Rows[0][0].ToString();
                    }
                    else
                    {
                        comboCliente.IsDropDownOpen = false;
                    }
                }
                else
                {
                    comboCliente.IsDropDownOpen = false;
                    comboCliente.ItemsSource = null;
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(string.Format("{0} Error:  {1}, Carga de Imagen de un producto Incorrecta ", DateTime.Now, ex.Message));
                MessageBox.Show("Error Inesperado Contacte con el departamento de sistemas");
            }
        }

        private void comboCliente_DropDownOpened(object sender, EventArgs e)
        {

        }

        private void BtExist_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnquitar_Click(object sender, RoutedEventArgs e)
        {

            DataRowView datarow = (DataRowView)dataProduct.SelectedItem;
            int id = int.Parse(datarow.Row.ItemArray[0].ToString());

            

        }

        

        private void bntCliente_Click(object sender, RoutedEventArgs e)
        {
            ViewCliente cli = new ViewCliente();
            cli.ShowDialog();
        }

        private void btnlim_Click(object sender, RoutedEventArgs e)
        {
            products.Clear();
            dtProductl.ItemsSource = null;
        }
    }
}
