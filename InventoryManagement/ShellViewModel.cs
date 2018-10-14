namespace InventoryManagement
{
    using Caliburn.Micro;
    using InventoryManagement.DashBoard;
    using InventoryManagement.LeftNavigation;
    using InventoryManagement.Settings;

    public class ShellViewModel : BaseMainViewModel, IHandle<Screen>
    {
        private LeftNavigationViewModel leftNavigation;

        public LeftNavigationViewModel LeftNavigation
        {
            get { return leftNavigation; }
            set
            {
                leftNavigation = value;
                NotifyOfPropertyChange(() => LeftNavigation);
            }
        }

        private Screen mainView;

        public Screen MainView
        {
            get { return mainView; }
            set
            {
                mainView = value;
                NotifyOfPropertyChange(() => MainView);
            }
        }

        private SettingsViewModel settingsView;

        public SettingsViewModel SettingsView
        {
            get { return settingsView; }
            set
            {
                settingsView = value;
                NotifyOfPropertyChange(() => SettingsView);
            }
        }

        public ShellViewModel()
        {
            LeftNavigation = IoC.Get<LeftNavigationViewModel>();
            MainView = IoC.Get<DashBoardViewModel>();
        }

        public void SetMainView()
        {
        }

        public void Handle(Screen message)
        {
            MainView = message;
        }
    }
}