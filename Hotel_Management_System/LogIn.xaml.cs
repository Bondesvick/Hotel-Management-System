using Hotel_Management_System.MessageBoxes;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Input;

namespace Hotel_Management_System
{
    /// <summary>
    /// Interaction logic for LogIn.xaml
    /// </summary>
    public partial class LogIn : Window
    {
        private AlertOK errorMsg;

        public LogIn()
        {
            InitializeComponent();
            UserNameBox.Focus();
        }

        private void ShutDown_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        /// <summary>
        /// LogIn button click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LogInButton_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(UserNameBox.Text))
            {
                errorMsg = new AlertOK("Message", "Please enter your user name!");
                errorMsg.ShowDialog();

                //MessageBox.Show("Please enter your user name!", "Message", MessageBoxButton.OK, MessageBoxImage.Warning);
                UserNameBox.Focus();
                return;
            }
            try
            {
                using (HotelManagementSystemEntities test = new HotelManagementSystemEntities())
                {
                    var query = from o in test.LogIns where o.UserName == UserNameBox.Text && o.PassWord == PassWordBox.Password select o;
                    if (query.SingleOrDefault() != null)
                    {
                        MainWindow MainHome = new MainWindow();

                        this.Close();
                        //Application.Current.Shutdown();

                        MainHome.ShowDialog();
                        // this.LogInPage.Close();
                    }
                    else
                    {
                        errorMsg = new AlertOK("Message", "Your user-name or password is incorrect.");
                        errorMsg.ShowDialog();
                        // MessageBox.Show("Your user-name or password is incorrect.","Message",MessageBoxButton.OK,MessageBoxImage.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                errorMsg = new AlertOK("Message", ex.Message);
                errorMsg.ShowDialog();
                //MessageBox.Show(ex.Message,"Message",MessageBoxButton.OK,MessageBoxImage.Error);
            }
        }

        private void UserNameBox_TextInput(object sender, TextCompositionEventArgs e)
        {
            if (UserNameBox.Text.Length == 13)
            {
                this.PassWordBox.Focus();
            }
        }

        private void PassWordBox_TextInput(object sender, TextCompositionEventArgs e)
        {
        }
    }
}