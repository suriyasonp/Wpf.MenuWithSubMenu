using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace MenuWithSubMenu.ViewModel
{
    public class SideMenuViewModel
    {
        // To call resource dictionary in our code behind

        ResourceDictionary dictionary = (ResourceDictionary)Application.LoadComponent(new Uri("/MenuWithSubMenu;component/Assets/IconDictionary.xaml", UriKind.RelativeOrAbsolute));

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
                                    SubMenuText ="All Users"
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
        public PathGeometry PathData { get; set; }
        public string MenuText { get; set; }
        public List<SubMenuItemsData> SubMenuList { get; set; }

        // To add click event in buttons by ICommand to switch pages when specific button is clicked.
        public MenuItemsData()
        {
            Command = new CommandViewModel(Execute);
        }

        public ICommand Command { get; }
        private void Execute()
        {
            string menuText = MenuText.Replace(" ", string.Empty);
            if (!string.IsNullOrEmpty(menuText))
            {
                navigateToPage(menuText);
            }
        }

        private void navigateToPage(string menu)
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

    public class SubMenuItemsData
    {
        public PathGeometry PathData { get; set; }
        public string SubMenuText { get; set; }

        public SubMenuItemsData()
        {
            SubMenuCommand = new CommandViewModel(Execute);
        }

        public ICommand SubMenuCommand { get; }
        private void Execute()
        {
            string subMenuText = SubMenuText.Replace(" ", string.Empty);
            if (!string.IsNullOrEmpty(subMenuText))
            {
                navigateToPage(subMenuText);
            }
        }

        private void navigateToPage(string menu)
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