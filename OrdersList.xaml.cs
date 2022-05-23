using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Client
{
    public partial class OrdersList : Window
    {
        public StackPanel[] s1;
        private Guid id;
        public DataManager dataManager;

        public List<Jewelery> Jewelery;
        public List<Order> Order;
        public List<OrderDetail> OrderDetail;

        public OrdersList()
        {
            InitializeComponent();
            this.Loaded += Window_Initialized;
        }

        private void Window_Initialized(object sender, EventArgs e)
        {
            s1 = new StackPanel[30];
            dataManager = new DataManager();
            Jewelery = dataManager.Jewelery;
            Order = dataManager.Order;
            OrderDetail = dataManager.OrderDetail;


            int j = 0;
            foreach (Order order in Order)
            {
                s1[j] = new StackPanel();
                s1[j].Background = new SolidColorBrush(Colors.LightBlue);
                s1[j].Orientation = Orientation.Vertical;
                Label labell = new Label();
                labell.Content = order.Name + "  " + order.Surname;
                labell.FontSize = 25;
                s1[j].Children.Add(labell);

                labell = new Label();
                labell.Content = order.Phone;
                labell.FontSize = 20;
                s1[j].Children.Add(labell);

                labell = new Label();
                labell.Content = order.Mail;
                labell.FontSize = 20;
                s1[j].Children.Add(labell);

                s1[j].Margin = new Thickness(3, 5, 0, 0);
                MainRoot.Children.Add(s1[j]);

                Button button = new Button();
                button.Content = order.Id.ToString();
                button.Click += Button_Click;
                MainRoot.Children.Add(button);

                j++;
            }

            Button buttonex = new Button();
            buttonex.Content = "Выйти";
            buttonex.Click += new RoutedEventHandler(Button_Clickex);
            MainRoot.Children.Add(buttonex);
        }

        private void Button_Clickex(object sender, RoutedEventArgs e)
        {
            this.Owner.Visibility = Visibility.Visible;
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button senderButton = sender as Button;
            var item = Guid.Parse(senderButton.Content.ToString());
            id = item;
            OrderList orderWindow = new OrderList(id, OrderDetail, Jewelery);
            orderWindow.Owner = this;
            orderWindow.Show();
        }
    }
}
