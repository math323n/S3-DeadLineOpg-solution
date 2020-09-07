using S3_DeadLineOpg.DataAccess;
using S3_DeadLineOpg.Entities;
using S3_DeadLineOpg.GUI.ViewModel;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace S3_DeadLineOpg.GUI.UserControls
{
    /// <summary>
    /// Interaction logic for LoginControl.xaml
    /// </summary>
    public partial class LoginControl: UserControl
    {
        readonly CustomerViewModel customersViewModel;

        private bool isLoaded;
        readonly OrdersControl ordersControl;
        CustomerRepository repo;
        public LoginControl()
        {
            InitializeComponent();
            repo = new CustomerRepository();
            ordersControl = new OrdersControl();
            customersViewModel = DataContext as CustomerViewModel;
        }




        /// <summary>
        /// Is run when UserControl is loaded once
        /// </summary>
        /// <param name="sender"></param>s
        /// <param name="e"></param>
        private void OnLoaded(object sender, RoutedEventArgs e)
        {
            if(!isLoaded)
            {

                isLoaded = true;

                customersViewModel.Initialize();
            }
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {

            if(passwordBox.Text == "123")
            {
                Display(ordersControl);
            }
            else
            {
                Display(ordersControl);
            }
        }
        private void Display(UserControl userControl)
        {
            displayedUserControl.Content = userControl;
        }
    }

}
