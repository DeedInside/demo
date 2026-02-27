using demo.Models;
using demo.Windows.Product;
using demo.Windows.RequestWin;
using System.Windows;

namespace demo.Windows
{
    public partial class Main : Window
    {
        public Main()
        {
            InitializeComponent();
            BoxUserName.Text = "гость";
            PanelFind.Visibility = Visibility.Collapsed;
            PanelBottomButton.Visibility = Visibility.Collapsed;
        }
        public Main(User user)
        {
            InitializeComponent();
            BoxUserName.Text = user.Login;

            if(user.Role.Name == "админ")
            {
                BoxProduct.SelectionChanged += Selection_product;
            }
            else
            {
                PanelBottomAdmin.Visibility = Visibility.Collapsed;
            }
        }

        private void Button_exit_user(object sender, RoutedEventArgs e)
        {
            Authorization authorization = new Authorization();
            authorization.Show();
            this.Close();
        }

        private void Selection_product(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            EditProduct edit = new EditProduct();

            if (edit.ShowDialog() == true)
            {

            }
        }

        private void Button_add_product(object sender, RoutedEventArgs e)
        {
            AddProduct add = new AddProduct();
            if (add.ShowDialog() == true)
            {

            }
        }

        private void Button_request(object sender, RoutedEventArgs e)
        {
            RequestWindows request = new RequestWindows();
            if (request.ShowDialog() == true)
            {

            }
        }

        private void Buutton_delite_product(object sender, RoutedEventArgs e)
        {

        }

        private void Selection_filter(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {

        }
        private void Checker_sort_product(object sender, RoutedEventArgs e)
        {

        }
    }
}
