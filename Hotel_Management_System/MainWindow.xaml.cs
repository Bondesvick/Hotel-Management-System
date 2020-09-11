using Hotel_Management_System.MessageBoxes;
using Hotel_Management_System.Navigated_Pages;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Threading;

// THE ULTIMATE HOTEL MANAGEMENT SYSTEM

namespace Hotel_Management_System
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.MainWindow1.WindowState = WindowState.Maximized;
            this.ButtonMaximizeWindow.Visibility = Visibility.Collapsed;
            this.ButtonRostoreWindow.Visibility = Visibility.Visible;

            //Status bar Date display
            DispatcherTimer timer = new DispatcherTimer(new TimeSpan(0, 0, 1),
                DispatcherPriority.Normal, delegate
                {
                    this.dateText.Text = DateTime.Now.ToString();
                }, this.Dispatcher);
        }

        private void Card_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        // Double-Click event for the top bar
        private void Card_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            this.MainWindow1.WindowState ^= WindowState.Maximized;
            if (MainWindow1.WindowState == WindowState.Maximized)
            {
                ButtonRostoreWindow.Visibility = Visibility.Visible;
                ButtonMaximizeWindow.Visibility = Visibility.Collapsed;
            }
            else if (MainWindow1.WindowState == WindowState.Normal)
            {
                ButtonRostoreWindow.Visibility = Visibility.Collapsed;
                ButtonMaximizeWindow.Visibility = Visibility.Visible;
            }

            //this.MainWindow.WindowState ^= WindowState.Maximized;
        }

        private void ButtonClose_Click(object sender, RoutedEventArgs e)
        {
            bool gottenInfo;
            YesNo closeRequest = new YesNo("Close Request", "Are you sure you want to close this Window?");
            closeRequest.ShowDialog();
            gottenInfo = closeRequest.ReturnedDecision();
            if (gottenInfo)
            {
                Application.Current.Shutdown();
            }

            //if (MessageBox.Show("Are you sure you want to close this Window?", "Close Request", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            //{
            //    Application.Current.Shutdown();
            //}
            //this.Close();
        }

        // Minimize Button Click Event
        private void ButtonWindowMinimize_Click(object sender, RoutedEventArgs e)
        {
            this.MainWindow1.WindowState = WindowState.Minimized;
        }

        // Shut down Button Click Event
        private void PopUpShutDown_Click(object sender, RoutedEventArgs e)
        {
            bool gottenInfo;
            YesNo closeRequest = new YesNo("Log out Request", "Are you sure you want to log out?");
            closeRequest.ShowDialog();
            gottenInfo = closeRequest.ReturnedDecision();
            if (gottenInfo)
            {
                LogIn AnotherUser = new LogIn();
                this.Close();
                AnotherUser.ShowDialog();
            }

            //if (MessageBox.Show("Are you sure you want to log out?","LogOut Request",MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            //{
            //    LogIn AnotherUser = new LogIn();
            //    this.Close();
            //    AnotherUser.ShowDialog();

            //    //Application.Current.Shutdown();
            //}
        }

        // Side Menu Open and Close Button visibility toggle
        private void ButtonCloseMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonOpenMenu.Visibility = Visibility.Visible;
            ButtonCloseMenu.Visibility = Visibility.Collapsed;
        }

        private void ButtonOpenMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonOpenMenu.Visibility = Visibility.Collapsed;
            ButtonCloseMenu.Visibility = Visibility.Visible;
        }

        // Maximize and Restore Button visibility toggle and Events
        private void ButtonMaximizeWindow_Click(object sender, RoutedEventArgs e)
        {
            if (MainWindow1.WindowState == WindowState.Normal)
            {
                this.MainWindow1.WindowState = WindowState.Maximized;
                this.ButtonMaximizeWindow.Visibility = Visibility.Collapsed;
                this.ButtonRostoreWindow.Visibility = Visibility.Visible;
            }
        }

        private void ButtonRostoreWindow_Click(object sender, RoutedEventArgs e)
        {
            if (MainWindow1.WindowState == WindowState.Maximized)
            {
                this.MainWindow1.WindowState = WindowState.Normal;
                this.ButtonMaximizeWindow.Visibility = Visibility.Visible;
                this.ButtonRostoreWindow.Visibility = Visibility.Collapsed;
            }
        }

        //Side Menu List view Content selection Event
        private void ListViewMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int index = ListViewMenu.SelectedIndex;
            MoveCursorMenu(index);

            switch (index)
            {
                case 0:
                    //GridPrincipal.Children.Clear();
                    GridPrincipal2.Content = null;
                    GridPrincipal2.Content = new HomeDashBoard();
                    //StatusText.Content = "HOME";
                    break;

                case 1:
                    // GridPrincipal.Children.Clear();
                    GridPrincipal2.Content = null;
                    //GridPrincipal.Children.Add(new MainDashBoard());
                    GridPrincipal2.Content = new Costumer_Register();
                    //StatusText.Content = "COSTUMER REGISTER";
                    break;

                case 2:
                    GridPrincipal2.Content = null;
                    GridPrincipal2.Content = new RoomBooking();
                    //StatusText.Content = "ROOM BOOKING";
                    break;

                case 3:
                    GridPrincipal2.Content = null;
                    GridPrincipal2.Content = new MealRequest();
                    //StatusText.Content = "MEAL REQUEST";
                    break;

                case 4:
                    GridPrincipal2.Content = null;
                    GridPrincipal2.Content = new LaundryService();
                    //StatusText.Content = "LAUNDRY SERVICE";
                    break;

                case 5:
                    GridPrincipal2.Content = null;
                    GridPrincipal2.Content = new HallBooking();
                    //StatusText.Content = "HALL BOOKING";
                    break;

                case 6:
                    GridPrincipal2.Content = null;
                    GridPrincipal2.Content = new CarRental();
                    //StatusText.Content = "CAR RENTAL";
                    break;

                case 7:
                    GridPrincipal2.Content = null;
                    GridPrincipal2.Content = new Settings();
                    //StatusText.Content = "SETTINGS";
                    break;

                case 8:
                    break;

                case 9:
                    GridPrincipal2.Content = null;
                    GridPrincipal2.Content = new Settings();
                    break;

                default:
                    break;
            }
        }

        // Function for cursor indicating selected List Item
        private void MoveCursorMenu(int index)
        {
            TrasitioningContentSlide.OnApplyTemplate();
            GridCursor.Margin = new Thickness(0, (60 * index), 0, 0);
        }

        private void PopUpSettings_Click(object sender, RoutedEventArgs e)
        {
            ListViewMenu.SelectedIndex = 7;

            // GridPrincipal2.Content = null;
            // GridPrincipal2.Content = new Settings();
        }

        private void SideBarStack_MouseLeave(object sender, MouseEventArgs e)
        {
            this.GridMenu.Width = 60;
        }

        private void GridMenu_MouseLeave(object sender, MouseEventArgs e)
        {
            this.GridMenu.Width = 60;
        }

        private void GridMenu_LostFocus(object sender, RoutedEventArgs e)
        {
            this.GridMenu.Width = 60;
        }

        private void NotifiMenuCloseBtn_Click(object sender, RoutedEventArgs e)
        {
            NotifiMenuOpenBtn.Visibility = Visibility.Visible;
        }

        private void NotifiMenuOpenBtn_Click(object sender, RoutedEventArgs e)
        {
            NotifiMenuOpenBtn.Visibility = Visibility.Collapsed;
        }

        private void PopUpWindowClose_Click(object sender, RoutedEventArgs e)
        {
            HelpBtn.Visibility = Visibility.Visible;
            PopUpWindow.Height = 0.0;
            //MainBody.Background = null;
        }

        private void HelpBtn_Click(object sender, RoutedEventArgs e)
        {
            HelpBtn.Visibility = Visibility.Collapsed;
            //MainBody.OpacityMask = Brushes.Coral;
        }

        private void About_Click(object sender, RoutedEventArgs e)
        {
        }

        private void HlpPup_Click(object sender, RoutedEventArgs e)
        {
            PopUpWindow.Height = 680.0;
        }

        //private void Confirm_Click(object sender, RoutedEventArgs e)
        //{
        //    string title = "Just a Message";
        //    string Message = "You are just about to do something!";

        //    AlertOK showAlert = new AlertOK(title, Message);

        //    showAlert.ShowDialog();

        //}
    }
}