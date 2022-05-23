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
    public partial class OrderList : Window
    {
        public StackPanel[] s1;
        public Guid ID;
        public List<Jewelery> Jewelery;
        public List<OrderDetail> OrderDetail;


        public OrderList(Guid ID, List<OrderDetail> orderDetail, List<Jewelery> jewelery)
        {
            this.OrderDetail = orderDetail;
            this.Jewelery = jewelery;
            this.ID = ID;
            InitializeComponent();
            this.Loaded += Window_Initialized;
        }

        private void Window_Initialized(object sender, EventArgs e)
        {
            s1 = new StackPanel[30];
            int j = 0;
            foreach (OrderDetail orderDet in OrderDetail)
            {
                if (orderDet.OrderId == ID)
                {
                    Jewelery jew = new Jewelery();

                    jew = Jewelery.FirstOrDefault(itm => itm.Id == orderDet.JeweleryId);

                    s1[j] = new StackPanel();
                    s1[j].Background = new SolidColorBrush(Colors.LightBlue);
                    s1[j].Orientation = Orientation.Vertical;
                    Label labell = new Label();
                    labell.Content = jew.Name;
                    labell.FontSize = 25;
                    s1[j].Children.Add(labell);

                    Image img = new Image();
                    BitmapImage logo1 = new BitmapImage();
                    logo1.BeginInit();
                    logo1.UriSource = new Uri("C:/Users/onico/source/repos/WebApp/WebApp/wwwroot/images/" + jew.Image);
                    logo1.EndInit();
                    img.Source = logo1;
                    img.Height = 250;
                    img.Width = 250;
                    s1[j].Children.Add(img);

                    labell = new Label();
                    labell.Content = jew.Price;
                    labell.FontSize = 20;
                    s1[j].Children.Add(labell);

                    s1[j].Margin = new Thickness(3, 5, 0, 0);
                    MainRoot.Children.Add(s1[j]);

                    j++;
                }
            }
        }
    }
}
