using System.Windows;

namespace demo.Windows.RequestWin
{
    public partial class EditRequest : Window
    {
        public EditRequest()
        {
            InitializeComponent();
        }

        private void Button_save(object sender, RoutedEventArgs e)
        {

        }

        private void Button_exit(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }
    }
}
