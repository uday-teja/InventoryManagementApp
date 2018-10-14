using System;
using Caliburn.Micro;

namespace InventoryManagement.Model.Models
{
    public class DeliveryChallan : PropertyChangedBase
    {
        private int number;

        public int Number
        {
            get { return number; }
            set
            {
                number = value;
                NotifyOfPropertyChange(() => Number);
            }
        }

        private DateTime date;

        public DateTime Date
        {
            get { return date; }
            set
            {
                date = value;
                NotifyOfPropertyChange(() => Date);
            }
        }

        private Customer customer;

        public Customer Customer
        {
            get { return customer; }
            set
            {
                customer = value;
                NotifyOfPropertyChange(() => Customer);
            }
        }

        private int customerDcNo;

        public int CustomerDcNo
        {
            get { return customerDcNo; }
            set
            {
                customerDcNo = value;
                NotifyOfPropertyChange(() => CustomerDcNo);
            }
        }

        private DateTime customerDcTime;

        public DateTime CustomerDcDate
        {
            get { return customerDcTime; }
            set
            {
                customerDcTime = value;
                NotifyOfPropertyChange(() => CustomerDcDate);
            }
        }
    }
}