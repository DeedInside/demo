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
            BoxStatus.ItemsSource = context.Statuses.ToList();
            BoxStatus.SelectedItem = order.Status;
            
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
                    DialogResult = true;
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
