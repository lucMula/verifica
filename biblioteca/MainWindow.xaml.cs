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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace biblioteca
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        Biblioteca biblioteca;
        Libro libro1;
        private void btnLibro_Click(object sender, RoutedEventArgs e)
        {
            libro1 = new Libro(txtAutore.Text, txtTitolo.Text, int.Parse(txtannoDiPubblicazione.Text), txtEditore.Text, int.Parse(txtNumeroDiPagine.Text));

        }

        private void btnToString_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(libro1.toString());
        }

        private void btnTempoDiLettura_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(libro1.readingTime() + "h");
        }

        private void btnBliblioteca_Click(object sender, RoutedEventArgs e)
        {
            biblioteca = new Biblioteca(txtNome.Text, txtIndirizzo.Text, int.Parse(txtOraA.Text), int.Parse(txtOraC.Text));
        }

        private void btnAggiungi_Click(object sender, RoutedEventArgs e)
        {
            biblioteca.Aggiungi();
        }

        private void btnCercaTitolo_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(biblioteca.CercaTitolo( txtCercaTitolo.Text));
        }

        private void btnNumeroLibri_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(biblioteca.numeroDilibriTotali());
        }

        private void btnCercaAutore_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(biblioteca.ricercaLibriAutore(txtCercaAutore.Text));
        }
    }
}
