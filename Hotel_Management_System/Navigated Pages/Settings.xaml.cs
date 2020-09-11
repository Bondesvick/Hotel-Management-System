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
using Hotel_Management_System.Navigated_Pages.SettingsPages;

namespace Hotel_Management_System.Navigated_Pages
{
    /// <summary>
    /// Interaction logic for Settings.xaml
    /// </summary>
    public partial class Settings : UserControl
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void HotelDetails_Click(object sender, RoutedEventArgs e)
        {
            contents.Children.Clear();
            contents.Children.Add(new HotelInfo());
        }

        private void CurrencyRegister_Click(object sender, RoutedEventArgs e)
        {
            contents.Children.Clear();
            contents.Children.Add(new CurrencyTypeInfo());
        }

        private void HotelRoomPlan_Click(object sender, RoutedEventArgs e)
        {
            contents.Children.Clear();
            contents.Children.Add(new HotelRoomPlan());
        }

        private void RoomCategory_Click(object sender, RoutedEventArgs e)
        {
            contents.Children.Clear();
            contents.Children.Add(new SettingsPages.RoomCategoryType());
        }

        private void RoomsEntery_Click(object sender, RoutedEventArgs e)
        {
            contents.Children.Clear();
            contents.Children.Add(new Rooms());
        }

        private void CostumerID_Click(object sender, RoutedEventArgs e)
        {
            contents.Children.Clear();
            contents.Children.Add(new CostumerIdType());
        }

        private void SupplierDetails_Click(object sender, RoutedEventArgs e)
        {
            contents.Children.Clear();
            contents.Children.Add(new SupplierEntery());
        }
    }
}
