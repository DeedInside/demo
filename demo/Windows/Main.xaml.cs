using demo.Data;
using demo.Models;
using demo.UserControllers;
using demo.Windows.Products;
using demo.Windows.RequestWin;
using Microsoft.EntityFrameworkCore;
using System.Transactions;
using System.Windows;

namespace demo.Windows
{
    public partial class Main : Window
    {
        private DemoContext context;
        private User currentUser;
        public Main()
        {
            InitializeComponent();
            context = new DemoContext();
            BoxUserName.Text = "гость";
            PanelFind.Visibility = Visibility.Collapsed;
            PanelBottomButton.Visibility = Visibility.Collapsed;
            DrawProductItem();
        }
        public Main(User user)
        {
            InitializeComponent();
            context = new DemoContext();

            BoxUserName.Text = user.FullName;
            currentUser = user;
            DrawProductItem();

            if (user.RoleNavigation.Role1 == "Администратор")
            {
                BoxProduct.MouseDoubleClick += BoxProduct_MouseDoubleClick;
            }
            else
            {
                PanelBottomAdmin.Visibility = Visibility.Collapsed;
            }
        }
        private void DrawProductItem()
        {
            BoxProduct.Items.Clear();

            var prod = context.Products
                .Include(p => p.Name)
                .Include(p => p.Category)
                .Include(p => p.Manufacturer)
                .Include(p => p.OrderArticles)
                .Include(p => p.Supplier)
                .ToList();

            foreach (var item in prod)
            {
                if (item != null)
                {
                    ItemProduct xml = new ItemProduct(item);

                    BoxProduct.Items.Add(xml);
                }
            }
        }

        private void Button_exit_user(object sender, RoutedEventArgs e)
        {
            Authorization authorization = new Authorization();
            authorization.Show();
            this.Close();
        }

        private void BoxProduct_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
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
            RequestWindows request = new RequestWindows(currentUser);
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
