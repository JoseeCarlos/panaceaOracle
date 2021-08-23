﻿using System;
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
using System.Data;

namespace Panacea.Users
{
    /// <summary>
    /// Lógica de interacción para Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        UsuarioImpl implUsuario;
        ConfigImpl impleConfig;
        int contra = 0;

        public Window1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                implUsuario = new UsuarioImpl();
                DataTable dt = implUsuario.Login(txtUsername.Text, txtPassword.Password);
                if (dt.Rows.Count>0)
                {
                    // iniciar las variables de session 
                    Session.SessionId =int.Parse( dt.Rows[0][0].ToString());

                    Session.SessionUsername = dt.Rows[0][1].ToString();
                    Session.SessionRole= dt.Rows[0][3].ToString();
                    Session.SessionInicio = byte.Parse(dt.Rows[0][4].ToString());
                    Session.foto = byte.Parse(dt.Rows[0][5].ToString());
                    //INICIAMOS LAS VARIABLES GLOBALES
                    impleConfig = new ConfigImpl();
                    DataTable config = impleConfig.Get();
                    Config.pathFotoUsuario = config.Rows[0][0].ToString();
                    Config.pathFotoProducto = config.Rows[0][1].ToString();
                    

                    // desplegamos la pantalla principal
                    MainWindow win = new MainWindow();
                    win.Show();
                    this.Visibility = Visibility.Hidden;
                }
                else
                {
                    if (contra>=3)
                    {
                        MessageBox.Show("Demasiados Intentos Realizados se Cerrara la Aplicacion");
                        System.Diagnostics.Debug.WriteLine(string.Format("{0} Info:Error ,{1} Demasiados Intentos Realizados Se cierra la Aplicacion", DateTime.Now,txtPassword.Password+"-"+txtUsername.Text));
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Usuario y/o contrasenia incorrectos");
                        System.Diagnostics.Debug.WriteLine(string.Format("{0} Info:Error ,{1} Usuario y/o contrasenia incorrectos", DateTime.Now, txtPassword.Password + "-" + txtUsername.Text));
                        contra++;
                    }
                  
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(string.Format("{0} Info:Error ,", DateTime.Now, ex.Message));
                MessageBox.Show("Hubo un Problema Inesperado \n Comuniquese con el departamento de sistemas");
            }
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnREpass_Click(object sender, RoutedEventArgs e)
        {
            Vnrecuperarpass pass = new Vnrecuperarpass();
            pass.Show();
        }
    }
}
