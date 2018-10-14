using Caliburn.Micro;
using InventoryManagement.Dialogs.AddCompanyDialog;
using InventoryManagement.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace InventoryManagement.Settings
{
    public class SettingsViewModel : BaseMainViewModel
    {
        private AddCompanyDialogViewModel addCompanyDialog;

        public AddCompanyDialogViewModel AddCompanyDialog
        {
            get { return addCompanyDialog; }
            set
            {
                addCompanyDialog = value;
                NotifyOfPropertyChange(() => AddCompanyDialog);
            }
        }

       

        public SettingsViewModel()
        {
            this.AddCompanyDialog = IoC.Get<AddCompanyDialogViewModel>();
        }

        public void AddCompany()
        {
            this.AddCompanyDialog.IsAddCompanyDialog = true;
        }
    }
}