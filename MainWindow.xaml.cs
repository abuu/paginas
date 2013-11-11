using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DemoPaginas
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int Pagina = 1;

        public MainWindow()
        {
            InitializeComponent();
            frame.NavigationUIVisibility = NavigationUIVisibility.Hidden;
            //irPagina();
            frame.Navigate(new Uri("/Pagina1.xaml", UriKind.Relative));
        }

        private void Cerrar(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Anterior(object sender, RoutedEventArgs e)
        {
            Pagina--;
            irPagina();
        }

        private void Siguiente(object sender, RoutedEventArgs e)
        {
            Pagina++;
            irPagina();
        }

        private void irPagina()
        {
            frame.Navigate(new Uri("/Pagina" + Pagina.ToString() + ".xaml", UriKind.Relative));
            btnAnterior.IsEnabled = Pagina > 1 ? true : false;
            btnSiguiente.IsEnabled = Pagina < 4 ? true : false;
            /*switch (Pagina)
            {
                case 1:
                    btnAnterior.IsEnabled = false;
                    btnSiguiente.IsEnabled = true;
                    break;
                case 2:
                    btnAnterior.IsEnabled = true;
                    btnSiguiente.IsEnabled = true;
                    break;
                case 3:
                    btnAnterior.IsEnabled = true;
                    btnSiguiente.IsEnabled = false;
                    break;
            }*/
        }

    }
}
