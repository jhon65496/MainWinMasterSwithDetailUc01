using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainWinMasterUcDetailUcSwithFrm02.Repositories;
using MainWinMasterUcDetailUcSwithFrm02.ViewModels;
using MainWinMasterUcDetailUcSwithFrm02.Models;


namespace MainWinMasterUcDetailUcSwithFrm02.ViewModels.Design
{
    public static class GroupsDesignModel
    {
        public static GroupRepository groupRepository = new GroupRepository();
        public static GroupsViewModel ViewModel { get; } = new GroupsViewModel()
        {
            Groups = new ObservableCollection<Group>(groupRepository.GetAll())
            // View Model initialization here.
        };

    }
}
