using System;
using System.Windows;
using System.Windows.Input;

namespace MenuWithSubMenu.ViewModel
{
    public class DashboardViewmodel
    {
        public ICommand MenuCommand { get; }

        public DashboardViewmodel()
        {
            MenuCommand = new CommandViewModel(Execute);
        }

        private void Execute()
        {
            NavigateToPage("NewUser");
        }

        private void NavigateToPage(string menu)
        {
            foreach (Window window in Application.Current.Windows)
            {
                if (window.GetType() == typeof(MainWindow))
                {
                    ((MainWindow)window).MainWindowsFrame.Navigate(new Uri(string.Format("{0}{1}{2}", "Pages/", menu, ".xaml"), UriKind.RelativeOrAbsolute));
                }
            }
        }
    }
}
