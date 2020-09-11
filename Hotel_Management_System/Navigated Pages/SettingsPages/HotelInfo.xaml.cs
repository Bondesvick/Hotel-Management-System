using Hotel_Management_System.MessageBoxes;
using Microsoft.Win32;
using System;
using System.Windows;
using System.Windows.Controls;

namespace Hotel_Management_System.Navigated_Pages.SettingsPages
{
    /// <summary>
    /// Interaction logic for HotelInfo.xaml
    /// </summary>
    public partial class HotelInfo : UserControl
    {
        public HotelInfo()
        {
            InitializeComponent();
        }

        private void LogoBrowse_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                OpenFileDialog slctdPix = new OpenFileDialog(); //{ Filter = "JPEG|*.jpg", ValidateNames = true, Multiselect = false };

                slctdPix.ShowDialog();

                LogoImg.DataContext = slctdPix.FileName; //slctdPix.FileName;
            }
            catch (Exception ex)
            {
                AlertOK alert = new AlertOK("An Error Occurred", ex.Message);
            }
        }
    }
}