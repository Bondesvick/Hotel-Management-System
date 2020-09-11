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

namespace Hotel_Management_System.MessageBoxes
{
    /// <summary>
    /// Interaction logic for AlertOK.xaml
    /// </summary>
    public partial class AlertOK : Window
    {
        public AlertOK(string Title, string Message)
        {
            InitializeComponent();

            title.Text = Title;
            inFo.Text = Message;
        }

        private void Confirm_Click(object sender, RoutedEventArgs e)
        {
            this.Close();          
        }
    }
}
