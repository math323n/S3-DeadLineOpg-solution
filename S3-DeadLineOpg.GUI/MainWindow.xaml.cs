using S3_DeadLineOpg.DataAccess;
using S3_DeadLineOpg.GUI.ViewModel;

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

namespace S3_DeadLineOpg.GUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow: Window
    {

        private CustomerViewModel customersViewModel;
        private bool isLoaded;
        CustomerRepository repo;
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Get comboBox items async.
        /// </summary>
        /// <returns></returns>
        private void GetComboBoxItems()
        {


            for(int i = 0; i < customersViewModel.Customers.Count; i++)
            {
                loginBox.Items.Add(customersViewModel.Customers[i].CustomerId);
            }


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
                customersViewModel = new CustomerViewModel();
                repo = new CustomerRepository();
                isLoaded = true;
                DataContext = customersViewModel;
                customersViewModel.Initialize();
        
            }

        }
    }
}