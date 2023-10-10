using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using MainWinMasterUcDetailUcSwithFrm02.ViewModels;

namespace MainWinMasterUcDetailUcSwithFrm02
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            GroupsViewModel groupsViewModel = new GroupsViewModel();
            
            MainWindow mainmindow = new MainWindow();
            mainmindow.DataContext = groupsViewModel;
            mainmindow.Show();
        }

    }
}
