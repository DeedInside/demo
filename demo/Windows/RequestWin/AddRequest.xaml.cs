using System.Windows;

namespace demo.Windows.RequestWin
{
    public partial class AddRequest : Window
    {
        public AddRequest()
        {
            InitializeComponent();
        }

        private void Button_add(object sender, RoutedEventArgs e)
        {

        }

        private void Button_exit(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }
    }
}
