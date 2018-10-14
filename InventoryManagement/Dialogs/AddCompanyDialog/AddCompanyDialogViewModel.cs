using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;
using InventoryManagement.Data;
using InventoryManagement.Model.Models;

namespace InventoryManagement.Dialogs.AddCompanyDialog
{
    public class AddCompanyDialogViewModel : BaseMainViewModel
    {
        private bool isAddCompanyDialog;

        public bool IsAddCompanyDialog
        {
            get { return isAddCompanyDialog; }
            set
            {
                isAddCompanyDialog = value;
                NotifyOfPropertyChange(() => IsAddCompanyDialog);
            }
        }

        private Model.Models.Company company;

        public Model.Models.Company Company
        {
            get { return company; }
            set
            {
                company = value;
                NotifyOfPropertyChange(() => Company);
            }
        }

        public SQLiteService sQLiteService { get; set; }

        public AddCompanyDialogViewModel()
        {
            Company = new Model.Models.Company();
        }

        public void SaveCompany()
        {
            this.sQLiteService = new SQLiteService("Uday");
        }
    }
}