using System.Windows.Controls;
using MenuWithSubMenu.ViewModel;

namespace MenuWithSubMenu.Pages
{
    /// <summary>
    /// Interaction logic for Dashboard.xaml
    /// </summary>
    public partial class Dashboard : Page
    {
        public Dashboard()
        {
            InitializeComponent();

            this.DataContext = new DashboardViewmodel();
        }
    }
}
