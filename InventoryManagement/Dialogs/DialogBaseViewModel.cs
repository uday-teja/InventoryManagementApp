using Caliburn.Micro;
using MahApps.Metro.SimpleChildWindow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Dialogs
{
    public class DialogBaseViewModel : ChildWindow
    {
        private Screen content;

        public Screen Content
        {
            get { return content; }
            set
            {
                content = value;
            }
        }

        public DialogBaseViewModel(Screen screen)
        {
            this.Content = screen;
        }
    }
}