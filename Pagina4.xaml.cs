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
using System.Windows.Threading; // este usar con el control timer
namespace DemoPaginas
{
    /// <summary>
    /// Interaction logic for Pagina4.xaml
    /// </summary>
    public partial class Pagina4 : Page
    {

        System.Windows.Threading.DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
        public Pagina4()
        {
            InitializeComponent();
            InitializeComponent();
            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
            dispatcherTimer.Start();
        }

        private void progressBar1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }
        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = progressBar1.Value + 1;
        }
    }
}
