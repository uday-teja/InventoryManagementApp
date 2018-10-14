using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement
{
    public class BaseMainViewModel : Screen
    {
        public IEventAggregator eventAggregator;

        public BaseMainViewModel()
        {
            eventAggregator = IoC.Get<IEventAggregator>();
            eventAggregator.Subscribe(this);
        }

        public void ClosePopup()
        {

        }
    }
}