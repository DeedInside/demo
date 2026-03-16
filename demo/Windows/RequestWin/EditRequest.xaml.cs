using demo.Data;
using demo.Models;
using System.Windows;

namespace demo.Windows.RequestWin
{
    public partial class EditRequest : Window
    {
        private DemoContext context;
        public EditRequest(Order order)
        {
            InitializeComponent();
            context = new DemoContext();
            PanelOrder.DataContext = order;
            List<Status> orders = context.Statuses.ToList();
            BoxStatus.ItemsSource = orders;
            int a = orders.IndexOf(order.Status);
            BoxStatus.SelectedIndex = orders.IndexOf(order.Status);
            
        }

        private void Button_save(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(BoxDateDelivery.Text) &&
                !string.IsNullOrWhiteSpace(BoxDateOrder.Text) &&
                !string.IsNullOrWhiteSpace(BoxArc.Text) &&
                !string.IsNullOrWhiteSpace(BoxDelivary.Text))
            {
                try
                {
                    Order order = new Order()
                    {
                        OrderDate = DateTime.Parse(BoxDateOrder.Text),
                        DeliveryDate = DateTime.Parse(BoxDateDelivery.Text),
                        Code = double.Parse(BoxArc.Text),
                        PickupPoint = context.PickupPoints.FirstOrDefault(q => q.Adress == BoxDelivary.Text),
                        Status = BoxStatus.SelectedItem as Status
                    };
                    context.Orders.Add(order);
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Button_exit(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }
    }
}
