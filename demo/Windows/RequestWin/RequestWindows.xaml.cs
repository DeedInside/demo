using System.Windows;
using System.Windows.Controls;

namespace demo.Windows.RequestWin
{
    public partial class RequestWindows : Window
    {
        public RequestWindows()
        {
            InitializeComponent();
        }

        private void Selection_request(object sender, SelectionChangedEventArgs e)
        {
            
            if(true)
            {
                EditRequest edit = new EditRequest();
                
                if(edit.ShowDialog() == true)
                {

                }
            }
        }

        private void Button_add_reques(object sender, RoutedEventArgs e)
        {
            AddRequest add = new AddRequest();
            if(add.ShowDialog() == true)
            {

            }
        }

        private void Buutton_delite_reques(object sender, RoutedEventArgs e)
        {

        }

        private void Button_exit(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }
    }
}
