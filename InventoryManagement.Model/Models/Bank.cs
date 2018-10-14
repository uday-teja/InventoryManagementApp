using Caliburn.Micro;

namespace InventoryManagement.Model.Models
{
    public class Bank : PropertyChangedBase
    {
        private string accountNumber;

        public string AccountNumber
        {
            get { return accountNumber; }
            set
            {
                accountNumber = value;
                NotifyOfPropertyChange(() => AccountNumber);
            }
        }

        private string branch;

        public string Branch
        {
            get { return branch; }
            set
            {
                branch = value;
                NotifyOfPropertyChange(() => Branch);
            }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                NotifyOfPropertyChange(() => Name);
            }
        }

        private string ifscCode;

        public string IFSCCode
        {
            get { return ifscCode; }
            set
            {
                ifscCode = value;
                NotifyOfPropertyChange(() => IFSCCode);
            }
        }
    }
}