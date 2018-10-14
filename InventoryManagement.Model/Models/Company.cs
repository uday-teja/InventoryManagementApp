using Caliburn.Micro;

namespace InventoryManagement.Model.Models
{
    public class Company : PropertyChangedBase
    {
        private int id;

        public int ID
        {
            get { return id; }
            set
            {
                id = value;
                NotifyOfPropertyChange(() => ID);
            }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; NotifyOfPropertyChange(() => Name); }
        }

        private string address;

        public string Address
        {
            get { return address; }
            set { address = value; NotifyOfPropertyChange(() => Address); }
        }

        private string email;

        public string Email
        {
            get { return email; }
            set
            {
                email = value; NotifyOfPropertyChange(() => Email);
            }
        }

        private string mobileNo;

        public string MobileNo
        {
            get { return mobileNo; }
            set
            {
                mobileNo = value;
                NotifyOfPropertyChange(() => MobileNo);
            }
        }

        private string gstin;

        public string GSTIN
        {
            get { return gstin; }
            set
            {
                gstin = value;
                NotifyOfPropertyChange(() => GSTIN);
            }
        }

        private Bank bankDetails;

        public Bank BankDetails
        {
            get { return bankDetails; }
            set
            {
                bankDetails = value;
                NotifyOfPropertyChange(() => BankDetails);
            }
        }
    }
}