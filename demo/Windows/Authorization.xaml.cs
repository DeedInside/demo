using System.Windows;

namespace demo.Windows
{
    public partial class Authorization : Window
    {
        public Authorization()
        {
            InitializeComponent();
        }

        private void Button_authorization(object sender, RoutedEventArgs e)
        {

        }

        private void Button_authorization_gouest(object sender, RoutedEventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Close();
        }
    }
}
