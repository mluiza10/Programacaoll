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
        Disciplina dc;
        private void CalcularClick2(object sender, RoutedEventArgs e)
        {
            dc = new Disciplina(Nome.Text, int.Parse(Média.Text), Semestre.Text, Aprovado.IsChecked.Value);
            h.Inserir(dc);
            list.Items.Add(dc);
        }

        private void CalcularClick3(object sender, RoutedEventArgs e)
        {
            int f = list.SelectedIndex;
            list.Items.Remove(f);
            
            h.Excluir(list.SelectedIndex);
            
        }

       /* private void CalcularClick4(object sender, RoutedEventArgs e)
        {
            h.IRA();
        }*/

     
    }
}
