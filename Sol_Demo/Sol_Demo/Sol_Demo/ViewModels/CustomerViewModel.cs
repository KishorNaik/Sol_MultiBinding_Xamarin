using MvvmHelpers;
using Sol_Demo.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sol_Demo.ViewModels
{
    public class CustomerViewModel : BaseViewModel
    {
        public CustomerViewModel()
        {
            Customer = new CustomerModel();
        }

        private CustomerModel customer = null;

        public CustomerModel Customer
        {
            get => customer;
            set => base.SetProperty(ref customer, value);
        }
    }
}