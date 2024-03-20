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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace prac2ET
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        BeautySalEntities context = new BeautySalEntities();
        public MainWindow()
        {
            InitializeComponent();

            var result = from booking in context.Bookings
                         join client in context.Clients on booking.Client_ID equals client.ID_Clients
                         join service in context.Servicess on booking.Servicess_ID equals service.ID_Servicess 
                         select new
                         {
                             ClientName = client.ClientsName,
                             ClientPhone = client.PhoneNumber,
                             ServiceName = service.ServiceName,
                             ClientAdress=client.ClientsAddress
                         };
            dgBooking.ItemsSource = result.ToList();
        }
    }
}

