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
using Hotel_Management_System.Navigated_Pages.DashBoardPages;

namespace Hotel_Management_System
{
    /// <summary>
    /// Interaction logic for HomeDashBoard.xaml
    /// </summary>
    public partial class HomeDashBoard : UserControl
    {
        public HomeDashBoard()
        {
            InitializeComponent();
            GridMain.Children.Add(new Home());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int index = int.Parse(((Button)e.Source).Uid);
            CursorTrasitioningContentSlide.OnApplyTemplate();

            GridCursor.Margin = new Thickness(10 + (150 * index), 0, 0, 0);

            switch (index)
            {
                case 0:
                    //GridMain.Background = Brushes.Aquamarine;
                    GridMain.Children.Clear();
                   
                        GridMain.Children.Add(new Home());
                    
                    //GridMain.Children.Add(new Home());
                    //GridMain.Background = Brushes.White;
                    break;
                case 1:
                    GridMain.Children.Clear();
                    //GridMain.Background = Brushes.Beige;
                    GridMain.Children.Add(new Rooms());
                    break;
                case 2:
                    GridMain.Children.Clear();
                    GridMain.Children.Add(new Halls());
                    //GridMain.Background = Brushes.CadetBlue;
                    break;
                case 3:
                    GridMain.Children.Clear();
                    GridMain.Children.Add(new Restaurants());
                    //GridMain.Background = Brushes.DarkBlue;
                    break;
                case 4:
                    GridMain.Children.Clear();
                    GridMain.Children.Add(new Bars());
                    //GridMain.Background = Brushes.Firebrick;
                    break;
                case 5:
                    GridMain.Children.Clear();
                    GridMain.Children.Add(new Meals());
                    //GridMain.Background = Brushes.Gainsboro;
                    break;
                case 6:
                    GridMain.Children.Clear();
                    GridMain.Children.Add(new Views());
                    //GridMain.Background = Brushes.HotPink;
                    break;
                case 7:
                    GridMain.Children.Clear();
                    GridMain.Children.Add(new Gardens());
                    break;
            }
        }
    }
}
