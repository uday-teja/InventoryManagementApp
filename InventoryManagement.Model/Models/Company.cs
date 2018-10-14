using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;

namespace InventoryManagement.Model.Models
{
    public class Company : PropertyChangedBase
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; NotifyOfPropertyChange(() => Name); }
        }

        public string Address;
        public string Email;
        public int MobileNo;
        public string GSTIN;
    }
}