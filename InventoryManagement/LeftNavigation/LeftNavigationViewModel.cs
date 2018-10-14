using Caliburn.Micro;
using InventoryManagement.DashBoard;
using InventoryManagement.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.LeftNavigation
{
    public class LeftNavigationViewModel : BaseMainViewModel
    {
        public void Settings()
        {
            eventAggregator.PublishOnUIThread(new SettingsViewModel());
        }

        public void HomeClick()
        {
            eventAggregator.PublishOnUIThread(new DashBoardViewModel());
        }

        public void SettingsClick()
        {
            eventAggregator.PublishOnUIThread(new SettingsViewModel());
        }
    }
}