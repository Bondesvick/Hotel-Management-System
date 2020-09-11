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
using System.IO;
using Hotel_Management_System.MessageBoxes;


namespace Hotel_Management_System
{
    /// <summary>
    /// Interaction logic for Costumer_Register.xaml
    /// </summary>
    public partial class Costumer_Register : UserControl
    {
        HotelManagementSystemEntities test = new HotelManagementSystemEntities();
        public static DataGrid dataGrid;
        //DateTime currentDate;
        // DateTime dateTime = new DateTime();

        public Costumer_Register()
        {
            InitializeComponent();
            dataGridBind();
            setInitialValues();


        }



        //public string _FirstName { get; set; }

        //8\
        // public BindableCollection DatagridRegister { get; set; }
        private void dataGridBind()
        {
            try
            {
                costumerRegisterDataGrid1.ItemsSource = test.CostumerRegisters.ToList();
                dataGrid = costumerRegisterDataGrid1;
                //public var LoadedData = test.CostumerRegisters.ToList();

                // lovar item = test.CostumerRegisters;
                //DatagridRegister = item;
                //DataContext = DatagridRegister;
                //costumerRegisterDataGrid1.ItemsSource = test.CostumerRegisters;
            }
            catch (Exception ex)
            {
                AlertOK decision = new AlertOK("Something went wrong!", ex.Message);
                decision.ShowDialog();
                //MessageBox.Show(e.Message);
            }

        }

        public void setInitialValues()
        {
            try
            {
                var copyFirstName = (costumerRegisterDataGrid1.SelectedItem as CostumerRegister).FirstName;
                var copyLastName = (costumerRegisterDataGrid1.SelectedItem as CostumerRegister).LastName;
                var copyGender = (costumerRegisterDataGrid1.SelectedItem as CostumerRegister).Gender;
                var copyTellNo = (costumerRegisterDataGrid1.SelectedItem as CostumerRegister).TellNo;
                var copyOccupation = (costumerRegisterDataGrid1.SelectedItem as CostumerRegister).Occupation;
                var copyNOKName = (costumerRegisterDataGrid1.SelectedItem as CostumerRegister).NxtOfKinName;
                var copyNOKNum = (costumerRegisterDataGrid1.SelectedItem as CostumerRegister).NxtOfKinNumber;
                var copyNOKReltn = (costumerRegisterDataGrid1.SelectedItem as CostumerRegister).NxtOfKinRelationship;
                //var copyRegDate = (costumerRegisterDataGrid1.SelectedItem as CostumerRegister).DateRegistered;
                var copyAddress1 = (costumerRegisterDataGrid1.SelectedItem as CostumerRegister).Address1;
                var copyAddress2 = (costumerRegisterDataGrid1.SelectedItem as CostumerRegister).Address2;
                var copyImage = (costumerRegisterDataGrid1.SelectedItem as CostumerRegister).Picture;

                //var item = (costumerRegisterDataGrid1.SelectedItem as CostumerRegister).FirstName;
                //_FirstName = item;
                //DataContext = _FirstName;

                firstNameTextBox.Text = copyFirstName;
                lastNameTextBox.Text = copyLastName;
                genderComboBox.Text = copyGender;
                phoneNumberTextBox1.Text = copyTellNo;
                occupationTextBox1.Text = copyOccupation;
                nextOfKinName.Text = copyNOKName;
                nextOfKinPhone.Text = copyNOKNum;
                nextOfKinRelation.Text = copyNOKReltn;

                //regDate.Text = copyRegDate;
                address1TextBox.Text = copyAddress1;
                address2TextBox.Text = copyAddress2;
            }
            catch (Exception ex)
            {
                AlertOK alerting = new AlertOK("Something went wrong!",ex.Message);
                alerting.ShowDialog();
                //MessageBox.Show(e.Message, "Message", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        private void CostumerRegisterDataGrid1_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            // costumerRegisterDataGrid1.SelectedItem.
            setInitialValues();
        }

        private void RefreshDataGrid()
        {
            try
            {
                costumerRegisterDataGrid1.ItemsSource = test.CostumerRegisters.ToList();
            }
            catch (Exception ex)
            {
                AlertOK decision = new AlertOK("Something went wrong!", ex.Message);
                decision.ShowDialog();
                //MessageBox.Show(ex.Message);
            }
        }

        private void ScrollUp()
        {
            var numberOfCells = costumerRegisterDataGrid1.Items.Count - 2;
            var selectedIndex = costumerRegisterDataGrid1.SelectedIndex;
            costumerRegisterDataGrid1.ScrollIntoView(selectedIndex);

            try
            {


                if (selectedIndex == 0)
                {
                    costumerRegisterDataGrid1.SelectedIndex = numberOfCells;
                }
                else
                {
                    costumerRegisterDataGrid1.SelectedIndex = selectedIndex - 1;
                }
            }
            catch (Exception)
            {
                //AlertOK decision = new AlertOK("Something went wrong!", ex.Message);
                //decision.ShowDialog();
                costumerRegisterDataGrid1.SelectedIndex = 0;
            }
        }

        private void ScrollDown()
        {
            //var selectedIndex = costumerRegisterDataGrid1.SelectedIndex;
            //costumerRegisterDataGrid1.SelectedIndex = selectedIndex + 1;

            // if(costumerRegisterDataGrid1.SelectedIndex = las)
            int itemsCount = costumerRegisterDataGrid1.Items.Count - 2;
            var selectedIndex = costumerRegisterDataGrid1.SelectedIndex;
            costumerRegisterDataGrid1.ScrollIntoView(selectedIndex);

            try
            {
                if (costumerRegisterDataGrid1.SelectedIndex == itemsCount)
                {
                    costumerRegisterDataGrid1.SelectedIndex = 0;
                }
                else
                {
                    costumerRegisterDataGrid1.SelectedIndex = selectedIndex + 1;
                }

            }
            catch (Exception)
            {
                //AlertOK decision = new AlertOK("Something went wrong!", ex.Message);
                //decision.ShowDialog();
                costumerRegisterDataGrid1.SelectedIndex = 0;
            }
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            RegPanel.IsEnabled = false;
            //test = new HotelManagementSystemEntities();
            //CostumerRegister.DataSource = test.CostumerRegisters.ToList();
            //costumerRegisterDataGrid1.da


            // Do not load your data at design time.
            // if (!System.ComponentModel.DesignerProperties.GetIsInDesignMode(this))
            // {
            // 	//Load your data here and assign the result to the CollectionViewSource.
            // 	System.Windows.Data.CollectionViewSource myCollectionViewSource = (System.Windows.Data.CollectionViewSource)this.Resources["Resource Key for CollectionViewSource"];
            // 	myCollectionViewSource.Source = your data
            // }
        }

        /// <summary>
        /// A method used to wipe all text boxes for new entries
        /// </summary>
        private void wipeTextBoxes()
        {
            RegPanel.IsEnabled = true;
            firstNameTextBox.Text = lastNameTextBox.Text = genderComboBox.Text = occupationTextBox1.Text = phoneNumberTextBox1.Text = nextOfKinName.Text = nextOfKinPhone.Text = nextOfKinRelation.Text = address1TextBox.Text = address2TextBox.Text = null;
            firstNameTextBox.Focus();
        }

        /// <summary>
        /// Wipes the entery text boxes and keeps ready for new entries
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtNew_Click(object sender, RoutedEventArgs e)
        {

            wipeTextBoxes();
        }

        private void BtEdit_Click(object sender, RoutedEventArgs e)
        {
            RegPanel.IsEnabled = true;
            setInitialValues();
            firstNameTextBox.Focus();
        }

        private void BtCancel_Click(object sender, RoutedEventArgs e)
        {
            RegPanel.IsEnabled = false;
        }

        /// <summary>
        /// Save Data on DataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtSave_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //currentDate = new DateTime();
                //string todaysDate = currentDate.Date.ToString();

                if ((costumerRegisterDataGrid1.SelectedItem as CostumerRegister).FirstName == firstNameTextBox.Text && (costumerRegisterDataGrid1.SelectedItem as CostumerRegister).LastName == lastNameTextBox.Text && (costumerRegisterDataGrid1.SelectedItem as CostumerRegister).TellNo == phoneNumberTextBox1.Text)
                {
                    AlertOK decision = new AlertOK("You are Attempting to duplicate a record!", "Item already exists!");
                    decision.ShowDialog();
                    //MessageBox.Show("You are Attempting to duplicate and item!", "Item already exists!", MessageBoxButton.OK, MessageBoxImage.Exclamation);

                }
                else
                {

                    CostumerRegister newMember = new CostumerRegister()
                    {
                        FirstName = firstNameTextBox.Text,
                        LastName = lastNameTextBox.Text,
                        Gender = genderComboBox.Text,
                        TellNo = phoneNumberTextBox1.Text,

                        Occupation = occupationTextBox1.Text,
                        NxtOfKinName = nextOfKinName.Text,
                        NxtOfKinNumber = nextOfKinPhone.Text,
                        NxtOfKinRelationship = nextOfKinRelation.Text,

                        DateRegistered = DateTime.Now.ToString(),
                        Address1 = address1TextBox.Text,
                        Address2 = address2TextBox.Text
                    };

                    test.CostumerRegisters.Add(newMember);
                    test.SaveChanges();
                    costumerRegisterDataGrid1.ItemsSource = test.CostumerRegisters.ToList();
                    RegPanel.IsEnabled = false;
                    NotifySnack.IsActive = true;
                }

            }
            catch (Exception ex)
            {
                AlertOK alerting = new AlertOK("Something went wrong", ex.Message);
                alerting.ShowDialog();
                //MessageBox.Show(ex.Message);
            }
            wipeTextBoxes();
        }

        /// <summary>
        /// Update Values on the Data Grid View
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtUpdate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //currentDate = new DateTime();
                //string todaysDate = currentDate.ToString();

                var Id = (costumerRegisterDataGrid1.SelectedItem as CostumerRegister).ClientID;
                    CostumerRegister updatMember = (from m in test.CostumerRegisters where m.ClientID == Id select m).Single();

                    updatMember.FirstName = firstNameTextBox.Text;
                    updatMember.LastName = lastNameTextBox.Text;
                    updatMember.Gender = genderComboBox.Text;
                    updatMember.TellNo = phoneNumberTextBox1.Text;

                    updatMember.Occupation = occupationTextBox1.Text;
                    updatMember.NxtOfKinName = nextOfKinName.Text;
                    updatMember.NxtOfKinNumber = nextOfKinPhone.Text;
                    updatMember.NxtOfKinRelationship = nextOfKinRelation.Text;

                    //updatMember.DateRegistered = DateTime.Now.ToString();
                    updatMember.Address1 = address1TextBox.Text;
                    updatMember.Address2 = address2TextBox.Text;

                    test.SaveChanges();
                    costumerRegisterDataGrid1.ItemsSource = test.CostumerRegisters.ToList();

                //NotifyTrasition();


            }
            catch (Exception ex)
            {
                AlertOK alerting = new AlertOK("Something went wrong check your enteries again", ex.Message);
                alerting.ShowDialog();
                //MessageBox.Show(ex.Message, "Something went wrong! Check your Enteries again", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }

        }

        //private void NotifyTrasition()
        //{
        //    TrasitioningPupNotifySlide.OnApplyTemplate();
        //    NotifyCard.Margin = new Thickness(0, 0, 150, 0);
        //}

        /// <summary>
        /// Delete Selection on the Data Grid View
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtDelete_Click(object sender, RoutedEventArgs e)
        {
            YesNo getEnquireis = new YesNo("Confirm Action!", "Are you sure that you want to delete this record?");
            getEnquireis.ShowDialog();
            if (getEnquireis.ReturnedDecision())
            {
                try
                {
                    int Id = (costumerRegisterDataGrid1.SelectedItem as CostumerRegister).ClientID;
                    var deleteMember = test.CostumerRegisters.Where(m => m.ClientID == Id).Single();
                    test.CostumerRegisters.Remove(deleteMember);
                    test.SaveChanges();
                    costumerRegisterDataGrid1.ItemsSource = test.CostumerRegisters.ToList();
                }
                catch (Exception ex)
                {
                    AlertOK alerting = new AlertOK("Something went wrong!", ex.Message);
                    alerting.ShowDialog();
                    //MessageBox.Show(ex.Message);
                }
            }



        }

        /// <summary>
        /// scroll Up Code
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Previuos_Click(object sender, RoutedEventArgs e)
        {
            ScrollUp();
        }

        /// <summary>
        /// Scroll Down Code
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Next_Click(object sender, RoutedEventArgs e)
        {
            ScrollDown();
        }

        private void RefreshButton_Click(object sender, RoutedEventArgs e)
        {

            RefreshDataGrid();
        }


        private void BrowsePicture_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //using (FileAccess jkk = new FileAccess)
                //{

                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// An event that triggers from search textbox to search datagrid items
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchBox_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(SearchBox.Text))
                {
                costumerRegisterDataGrid1.ItemsSource = test.CostumerRegisters.ToList();
                }
            else
                {
                //var query = from o in test.CostumerRegisters where o.ClientID.ToString() == SearchBox.Text || o.FirstName.Contains(SearchBox.Text) || o.LastName.Contains(SearchBox.Text) || o.TellNo.Contains(SearchBox.Text) || o.Address1.Contains(SearchBox.Text) || o.Address2.Contains(SearchBox.Text) select 0;
                //costumerRegisterDataGrid1.ItemsSource = query.ToList();

                    var filtered = test.CostumerRegisters.Where(details => details.FirstName.StartsWith(SearchBox.Text) || details.LastName.StartsWith(SearchBox.Text) || details.ClientID.ToString().StartsWith(SearchBox.Text) || details.TellNo.StartsWith(SearchBox.Text) || details.NxtOfKinName.StartsWith(SearchBox.Text));

                    costumerRegisterDataGrid1.ItemsSource = filtered.ToList();
                 }

            }
            catch (Exception)
            {
                RefreshDataGrid();
            }
        }

        private void CostumerRegisterDataGrid1_PreviewKeyDown(object sender, KeyEventArgs e)
        {

            if (e.Key == Key.Return)
            {
                try
                {
                    //currentDate = new DateTime();
                    //string todaysDate = currentDate.Date.ToString();

                    if ((costumerRegisterDataGrid1.SelectedItem as CostumerRegister).FirstName == firstNameTextBox.Text && (costumerRegisterDataGrid1.SelectedItem as CostumerRegister).LastName == lastNameTextBox.Text && (costumerRegisterDataGrid1.SelectedItem as CostumerRegister).TellNo == phoneNumberTextBox1.Text)
                    {
                        AlertOK decision = new AlertOK("You are Attempting to duplicate a record!", "Item already exists!");
                        decision.ShowDialog();
                        //MessageBox.Show("You are Attempting to duplicate and item!", "Item already exists!", MessageBoxButton.OK, MessageBoxImage.Exclamation);

                    }
                    else
                    {

                        CostumerRegister newMember = new CostumerRegister()
                        {
                            FirstName = firstNameTextBox.Text,
                            LastName = lastNameTextBox.Text,
                            Gender = genderComboBox.Text,
                            TellNo = phoneNumberTextBox1.Text,

                            Occupation = occupationTextBox1.Text,
                            NxtOfKinName = nextOfKinName.Text,
                            NxtOfKinNumber = nextOfKinPhone.Text,
                            NxtOfKinRelationship = nextOfKinRelation.Text,

                            DateRegistered = DateTime.Now.ToString(),
                            Address1 = address1TextBox.Text,
                            Address2 = address2TextBox.Text
                        };

                        test.CostumerRegisters.Add(newMember);
                        test.SaveChanges();
                        costumerRegisterDataGrid1.ItemsSource = test.CostumerRegisters.ToList();
                        RegPanel.IsEnabled = false;
                    }

                }
                catch (Exception)
                {
                    //AlertOK alerting = new AlertOK("Something went wrong", ex.Message);
                    //alerting.ShowDialog();
                    //MessageBox.Show(ex.Message);
                    RefreshDataGrid();
                }
            }

            //costumerRegisterDataGrid1.ItemsSource = test.CostumerRegisters.ToList();
            //RefreshDataGrid();

        }

        private void CostumerRegisterDataGrid1_PreviewKeyDown2(object sender, KeyEventArgs e)
        {
            YesNo userDecision = new YesNo("Confirm Action!", "Are you sure that you want to delete this record?");


            if (e.Key == Key.Delete)
            {

                userDecision.ShowDialog();
                bool result = userDecision.ReturnedDecision();
                if (result)
                {
                    try
                    {
                        int Id = (costumerRegisterDataGrid1.SelectedItem as CostumerRegister).ClientID;
                        var deleteMember = test.CostumerRegisters.Where(m => m.ClientID == Id).Single();
                        test.CostumerRegisters.Remove(deleteMember);
                        test.SaveChanges();
                        costumerRegisterDataGrid1.ItemsSource = test.CostumerRegisters.ToList();
                    }
                    catch (Exception)
                    {
                        //AlertOK decision = new AlertOK("Something went wrong!", ex.Message);
                        //decision.ShowDialog();

                        RefreshDataGrid();
                        //MessageBox.Show(ex.Message);
                    }
                }
            }
            else if (e.Key == Key.Up)
            {
                ScrollUp();
            }
            else if (e.Key == Key.Down)
            {
                ScrollDown();
            }
        }

        private void Previuos_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            ScrollUp();
        }

        private void Next_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            ScrollDown();
        }
    }
}
