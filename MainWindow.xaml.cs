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

namespace WpfApp2
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string VLogin {  get; set; }
        public string VPassword { get; set; }
        public MainWindow()
        {
            
            
            InitializeComponent();
            DataContext = this;


        }

        private void Btn_login(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Twój login to: " + this.VLogin);
        }
    }
}
