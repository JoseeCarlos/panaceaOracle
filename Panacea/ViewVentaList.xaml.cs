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
using Dao;
using Implemetation;
using System.Data;

namespace Panacea
{
    /// <summary>
    /// Lógica de interacción para ViewVentaList.xaml
    /// </summary>
    public partial class ViewVentaList : Window
    {
        Compra compra;
        CompraImpl implcompra;
        public ViewVentaList()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            selectCompra();
        }

        void selectCompra()
        {
            try
            {

                implcompra = new CompraImpl();

                dgVentasR.ItemsSource = null;
                dgVentasR.ItemsSource = implcompra.select().DefaultView;
                dgVentasR.Columns[0].Visibility = Visibility.Collapsed;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            implcompra = new CompraImpl();
            dgVentasR.ItemsSource = null;
            dgVentasR.ItemsSource = implcompra.serachDate(date1.Text,date2.Text).DefaultView;
            dgVentasR.Columns[0].Visibility = Visibility.Collapsed;
        }

        private void btnsalir_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void CoInabilitar_Click(object sender, RoutedEventArgs e)
        {
            DataRowView datarow = (DataRowView)dgVentasR.SelectedItem;
            int id = int.Parse(datarow.Row.ItemArray[0].ToString());
            compra = new Compra(id);
            implcompra = new CompraImpl();

            int res = implcompra.update(compra);

            if (res>0)
            {
                MessageBox.Show("Venta Anulada");
                selectCompra();
            }
            else
            {
                MessageBox.Show("No se Anulo la Venta");
            }

        }

        private void CodarBaja_Click(object sender, RoutedEventArgs e)
        {
            DataRowView datarow = (DataRowView)dgVentasR.SelectedItem;
            int id = int.Parse(datarow.Row.ItemArray[0].ToString());
            compra = new Compra(id);
            implcompra = new CompraImpl();

            int res = implcompra.delete(compra);

            if (res > 0)
            {
                MessageBox.Show("Venta Anulada");
                selectCompra();
            }
            else
            {
                MessageBox.Show("No se Anulo la Venta");
            }
        }
    }
}
