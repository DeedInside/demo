using System.Windows;

namespace demo.Windows.Products
{
    public partial class EditProduct : Window
    {
        public EditProduct()
        {
            InitializeComponent();
        }

        private void Button_exit(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }

        private void Button_save(object sender, RoutedEventArgs e)
        {

        }
    }
}
