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
            get
            {
                return new List<MenuItemsData>
                {
                    // Main Menu without SubMenu Button
                    new MenuItemsData()
                    {
                        PathData = (PathGeometry)dictionary["icon_dashboard"],
                        MenuText = "Dashboard",
                        SubMenuList = null
                    },

                    // Main Menu Button
                    new MenuItemsData()
                    {
                        PathData = (PathGeometry)dictionary["icon_users"],
                        MenuText = "Profile",
                        // SubMenu Button
                        SubMenuList = new List<SubMenuItemsData>
                        {
                            new SubMenuItemsData()
                            {
                                PathData = (PathGeometry)dictionary["icon_adduser"],
                                SubMenuText ="New User"
                            },
                            new SubMenuItemsData()
                            {
                                PathData = (PathGeometry)dictionary["icon_alluser"],
                                SubMenuText ="Add Users"
                            }
                        }
                    },  
                    // Main Menu Button
                    new MenuItemsData()
                    {
                        PathData = (PathGeometry)dictionary["icon_mails"],
                        MenuText = "Mails",
                        SubMenuList = new List<SubMenuItemsData>
                        {
                            // SubMenu Button
                            new SubMenuItemsData()
                            {
                                PathData = (PathGeometry)dictionary["icon_inbox"],
                                SubMenuText ="Inbox"
                            },
                            new SubMenuItemsData()
                            {
                                PathData = (PathGeometry)dictionary["icon_outbox"],
                                SubMenuText ="Outbox"
                            },
                            new SubMenuItemsData()
                            {
                                PathData = (PathGeometry)dictionary["icon_sentmail"],
                                SubMenuText ="Sent"
                            }
                        }
                    },
                    // Main Menu without SubMenu Button
                    new MenuItemsData()
                    {
                        PathData = (PathGeometry)dictionary["icon_settings"],
                        MenuText = "Settings",
                        SubMenuList = null
                    },
                };

            }
        }
    }


    public class MenuItemsData
    {
        // Icon data
        public PathGeometry? PathData { get; set; }
        public string? MenuText { get; set; }
        public List<SubMenuItemsData>? SubMenuList { get; set; }
    }

    public class SubMenuItemsData
    {
        public PathGeometry? PathData { get; set; }
        public string? SubMenuText { get; set; }
    }
}