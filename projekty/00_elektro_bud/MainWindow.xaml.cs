// fundament strony z pliku na githubie z lekcji
// różne źródła:
// https://learn.microsoft.com/en-us/dotnet/desktop/wpf/controls/listbox

//w aplikacji można dodawać produkty i je usuwać

using System.Collections.ObjectModel;
using System.Windows;

namespace Projekt1
{
    public partial class MainWindow : Window
    {
        ObservableCollection<string> Products = new ObservableCollection<string>();

        public MainWindow()
        {
            InitializeComponent();
            productList.ItemsSource = Products;
        }

        private void Add(object sender, RoutedEventArgs e)
        {
            string text = textProduct.Text.Trim();

            if (text == "")
            {
                return;
            }
            Products.Add(text);
            textProduct.Clear();
            textProduct.Focus();
        }

        private void Delete(object sender, RoutedEventArgs e)
        {
            if (productList.SelectedIndex == -1)
            {
                return;
            }
            Products.RemoveAt(productList.SelectedIndex);
            textProduct.Clear();
        }
    }
}