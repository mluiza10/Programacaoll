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

namespace Exer03
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

        private void CalcularClick(object sender, RoutedEventArgs e)
        {
            retângulo x = new retângulo();
            x.SetBase(double.Parse(txtB.Text));
            x.SetAltura(double.Parse(txtAlt.Text));


            txtArea.Text = x.CalcArea().ToString("0");
            txtD.Text = x.CalcDiagonal().ToString("0");
        }
    }
}
