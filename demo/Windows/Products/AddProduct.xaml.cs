using System.Windows;

namespace demo.Windows.Products
{
    public partial class AddProduct : Window
    {
        public AddProduct()
        {
            InitializeComponent();
        }

        private void Button_exit(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }

        private void Button_add(object sender, RoutedEventArgs e)
        {

        }
    }
}
