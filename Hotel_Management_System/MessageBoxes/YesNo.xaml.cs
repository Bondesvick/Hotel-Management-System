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
    /// Interaction logic for YesNo.xaml
    /// </summary>
    public partial class YesNo : Window
    {

        public bool value;
        public YesNo(string Title, string Message)
        {
            InitializeComponent();

            
            title.Text = Title;
            inFo.Text = Message;
        }

        private void NoBtn_Click(object sender, RoutedEventArgs e)
        {
            value = false;
            this.Close();
        }

        private void YesBtn_Click(object sender, RoutedEventArgs e)
        {
            value = true;
            this.Close();
        }

        public bool ReturnedDecision()
        {
            return value;
        }
    }
}
