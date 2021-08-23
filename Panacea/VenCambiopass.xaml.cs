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
using Dao;
using Model;
using Implemetation;


namespace Panacea
{
    /// <summary>
    /// Lógica de interacción para VenCambiopass.xaml
    /// </summary>
    public partial class VenCambiopass : Window
    {
        UsuarioImpl implusuario;
        Usuario usuario;

        public VenCambiopass()
        {
            InitializeComponent();
        }

        private void btncambiar_Click(object sender, RoutedEventArgs e)
        {
            if (txtpas1.Text==txtpas2.Text)
            {
                usuario = new Usuario(txtpas1.Text,0);
                implusuario = new UsuarioImpl();
                int res =implusuario.updatePassword(Session.SessionId,usuario);
                if (res>0)
                {
                    MessageBox.Show("Password Cambiado con Exito");
                    
                    this.Close();
                    
                    
                }
                 
            }
            else
            {
                MessageBox.Show("las contraseñas no son identicas"); 
            }
        }
    }
}
