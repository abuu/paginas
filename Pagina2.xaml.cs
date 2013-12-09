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
    /// Interaction logic for Pagina2.xaml
    /// </summary>
    public partial class Pagina2 : Page
    {
        public Pagina2()
        {
            InitializeComponent();
        }

        private void richTextBox1_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                System.IO.StreamReader sr = new System.IO.StreamReader("D:/isursemestre 5/bernabe/paginas-master/paginas-master/Terminos_Licencia.txt");
                //richTextBox1.Document = sr.ReadToEnd();
                System.Windows.Documents.FlowDocument doc = new FlowDocument();
                doc.Blocks.Add(new Paragraph(new Run(sr.ReadToEnd())));
                //doc.DataContext = sr.ReadToEnd();
                richTextBox1.Document = doc;
                sr.Close();
            }
            catch
            {
                MessageBox.Show("enlace incorrecto");
            }
        }

        private void checkBox1_Checked(object sender, RoutedEventArgs e)
        {
            ((MainWindow)App.Current.MainWindow).btnSiguiente.IsEnabled = true;
        }

        private void checkBox1_Unchecked(object sender, RoutedEventArgs e)
        {
            ((MainWindow)App.Current.MainWindow).btnSiguiente.IsEnabled = false;
        }
    }
}
