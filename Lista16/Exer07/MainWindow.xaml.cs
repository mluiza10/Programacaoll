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

namespace Exer07
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        Historico h;
        private void CalcularClick(object sender, RoutedEventArgs e)
        {
            h = new Historico();
        }
        
        private void CalcularClick2(object sender, RoutedEventArgs e)
        {
            Disciplina dc;
            dc = new Disciplina(Nome.Text, int.Parse(Média.Text), Semestre.Text, Aprovado.IsChecked.Value);
            h.Inserir(dc);
            list.ItemsSource = h.Listar();
           
        }

        private void CalcularClick3(object sender, RoutedEventArgs e)
        {
            int f = list.SelectedIndex;
           
            h.Excluir(list.SelectedIndex);
            list.ItemsSource = h.Listar();


        }

        private void CalcularClick4(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(h.IRA().ToString());
        }

     
    }
}
