using S3_DeadLineOpg.DataAccess;
using S3_DeadLineOpg.Entities;

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace S3_DeadLineOpg.GUI.ViewModel
{
    public class OrderViewModel: ViewModel, INotifyPropertyChanged
    {

        private Orders selectedOrder;


        #region Constructor
        public OrderViewModel()
        {
            Orders = new ObservableCollection<Orders>();
        }
        #endregion

        #region Collections
        public ObservableCollection<Orders> Orders { get; set; }

        public Orders SelectedOrder
        {
            get
            {
                return selectedOrder;
            }

            set
            {
                selectedOrder = value;
                OnPropertyChanged(nameof(SelectedOrder));
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
            OrderRepository orderRepository = new OrderRepository();
            IEnumerable<Orders> orders = orderRepository.GetAll();
            Orders.ReplaceWith(orders);
        }
        #endregion
    }
}