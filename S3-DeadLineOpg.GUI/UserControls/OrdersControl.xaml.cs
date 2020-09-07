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
        readonly OrderViewModel orderViewModel;
        private Orders selectedOrder;

        public OrdersControl()
        {
            InitializeComponent();
        }
    }
}
