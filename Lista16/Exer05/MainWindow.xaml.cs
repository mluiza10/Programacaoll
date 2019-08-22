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

namespace Exer05
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Numeros n = new Numeros();
            n.SetInicio(int.Parse(txtI.Text));
            n.SetFim(int.Parse(txtF.Text));
            bool bp, bi;
            if (check1.IsChecked == true) bp = true;
            else bp = false;
            if (check2.IsChecked == true) bi = true;
            else bi = false;
            lista.ItemsSource = n.Calc(bp, bi);
        }
    }
}
