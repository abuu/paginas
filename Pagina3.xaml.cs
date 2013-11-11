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
    /// Interaction logic for Pagina3.xaml
    /// </summary>
    public partial class Pagina3 : Page
    {
        public Pagina3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.FolderBrowserDialog dialogoRuta = new System.Windows.Forms.FolderBrowserDialog();
            if (dialogoRuta.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBox1.Text = dialogoRuta.SelectedPath;
            }
        }
    }
}
