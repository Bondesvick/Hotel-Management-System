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

namespace Hotel_Management_System.Navigated_Pages
{
    /// <summary>
    /// Interaction logic for RoomBooking.xaml
    /// </summary>
    public partial class RoomBooking : UserControl
    {
        public RoomBooking()
        {
            InitializeComponent();
            bindCombo();
        }

        public List<RoomCategoryType> Rooms { get; set; }
        

        private void bindCombo()
        {
            HotelManagementSystemEntities dc = new HotelManagementSystemEntities();
            var item = dc.RoomCategoryTypes.ToList();
            Rooms = item;
            DataContext = Rooms;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var item = RoomCategoryCombo.SelectedItem as RoomCategoryType;
            MessageBox.Show(item.RoomType.ToString());
        }
    }
}
