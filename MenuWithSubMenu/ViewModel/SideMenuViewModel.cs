using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace MenuWithSubMenu.ViewModel
{
    public class SideMenuViewModel
    {
        // To call resource dictionary in our code behind

        ResourceDictionary dictionary = (ResourceDictionary)Application.LoadComponent(new Uri("/MenuWithSubMenu;component/Assets/IconDictionary.xaml"));

        // Our source list for Menu Items.

        public List<MenuItemsData> MenuList
        {

        }
    }


    public class MenuItemsData
    {
        // Icon data
        public PathGeometry PathData { get; set; }
        public string MenuText { get; set; }
        public List<SubMenuItemsData> SubMenuList { get; set; }
    }

    public class SubMenuItemsData
    {
        public PathGeometry PathData { get; set; }
        public string SubMenuText { get; set; }
    }
}