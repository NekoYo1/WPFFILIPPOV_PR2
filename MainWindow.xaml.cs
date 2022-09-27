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

namespace WPFFILIPPOV_PR2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();            
            Itog.Text = "Ст. гр. ИСП Филиппов К.П.";
        }

        private void Schet_Click(object sender, RoutedEventArgs e)
        {
            Itog.Text += Environment.NewLine + "Практическая работа 2";
            double x = double.Parse(X.Text);
            Itog.Text += Environment.NewLine + "X =" + x.ToString();
            double y = double.Parse(Y.Text);
            Itog.Text += Environment.NewLine + "Y =" + y.ToString();
            double z = double.Parse(Z.Text);
            Itog.Text += Environment.NewLine + "Z =" + z.ToString();
            double b = (x * x / z) + (x / y) - (y / z * z * z);
            Itog.Text += Environment.NewLine + "Результат B = " + b.ToString();
        }
    }
}
