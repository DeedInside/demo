using System.Windows;

namespace demo.Windows
{
    public partial class Main : Window
    {
        public Main()
        {
            InitializeComponent();
            BoxUserName.Text = "гость";
        }
        public Main(int n)
        {
            InitializeComponent();
        }

        private void Button_exit_user(object sender, RoutedEventArgs e)
        {
            Authorization authorization = new Authorization();
            authorization.Show();
            this.Close();
        }
    }
}
