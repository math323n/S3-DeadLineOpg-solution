using S3_DeadLineOpg.DataAccess;
using S3_DeadLineOpg.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace S3_DeadLineOpg.GUI.ViewModel
{
    public class CustomerViewModel : ViewModel, INotifyPropertyChanged
    {
        private Customers selectedCustomer;
        protected ObservableCollection<Customers> customers;

        #region Constructor
        public CustomerViewModel()
        {
            Customers = new ObservableCollection<Customers>();
        }
        #endregion

        #region Collections
        public ObservableCollection<Customers> Customers { get; set; }

        public Customers SelectedCustomer
        {
            get
            {
                return selectedCustomer;
            }

            set
            {
                selectedCustomer = value;
                OnPropertyChanged(nameof(SelectedCustomer));
            }
        }

        #endregion

        #region Methods
        /// <summary>
        /// Initializes all customers
        /// </summary>
        public void Initialize()
        {
            LoadAllCustomers();
        }

        /// <summary>
        /// Loads all customers
        /// </summary>
        private void LoadAllCustomers()
        {
            CustomerRepository customerRepository = new CustomerRepository();
            IEnumerable<Customers> customers = customerRepository.GetAll();
            Customers.ReplaceWith(customers);
        }
        #endregion
    }
}
