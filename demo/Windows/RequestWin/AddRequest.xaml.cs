using demo.Data;
using demo.Models;
using System.Windows;

namespace demo.Windows.RequestWin
{
    public partial class AddRequest : Window
    {
        private DemoContext context;
        public AddRequest()
        {
            InitializeComponent();
            context = new DemoContext();
            BoxStatus.ItemsSource = context.Statuses.ToList();
        }

        private void Button_add(object sender, RoutedEventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(BoxDateDelivery.Text) && 
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
                catch(Exception ex)
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
