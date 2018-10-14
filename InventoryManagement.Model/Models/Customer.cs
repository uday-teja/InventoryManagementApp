using Caliburn.Micro;

namespace InventoryManagement.Model.Models
{
    public class Customer : PropertyChangedBase
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

        private Company company;

        public Company Company
        {
            get { return company; }
            set
            {
                company = value;
                NotifyOfPropertyChange(() => Company);
            }
        }
    }
}