using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;
using UiModel = InventoryManagement.Model.Models;
using DataModel = InventoryManagement.Data;

namespace InventoryManagement.Dialogs.AddCompanyDialog
{
    public class AddCompanyDialogViewModel : BaseMainViewModel
    {
        DataModel.Service Service;

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

        private UiModel.Company company;

        public UiModel.Company Company
        {
            get { return company; }
            set
            {
                company = value;
                NotifyOfPropertyChange(() => Company);
            }
        }


        public AddCompanyDialogViewModel()
        {
            Company = new UiModel.Company();
            Service = new DataModel.Service();
        }

        public void SaveCompany()
        {
            Service.AddCompany(AutoMapper.Mapper.Map<UiModel.Company, DataModel.Company>(Company));
        }
    }
}