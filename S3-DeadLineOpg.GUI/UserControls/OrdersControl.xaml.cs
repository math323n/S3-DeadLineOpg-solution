using S3_DeadLineOpg.DataAccess;
using S3_DeadLineOpg.Entities;
using S3_DeadLineOpg.GUI.ViewModel;
using System;
using System.Collections.Generic;
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
    /// Interaction logic for OrdersControl.xaml
    /// </summary>
    public partial class OrdersControl: UserControl
    {
        protected OrderViewModel orderViewModel;
        private Orders selectedOrder;
        private bool isLoaded;
        OrderRepository repo;

        public OrdersControl()
        {
            InitializeComponent();
            
            
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
                repo = new OrderRepository();
                isLoaded = true;
                orderViewModel = new OrderViewModel();
                DataContext = orderViewModel;
                orderViewModel.Initialize();

            }

        }
       
    }
   
}
