using System;
using System.Collections.Generic;
using System.Text;
// using MainWinMasterUcDetailUcSwithFrm02.ViewModels.Base;
// using MainWinMasterUcDetailUcSwithFrm02.Models;
using System.Windows.Automation.Peers;
using MainWinMasterUcDetailUcSwithFrm02.Models;
          
namespace MainWinMasterUcDetailUcSwithFrm02.ViewModels
{    
    internal class GroupViewModel : BaseVM
    {
     
        // === === === === === === ===
        public GroupViewModel(Group group)
        {
            this.group = group;
        }
        public GroupViewModel() : this(new Group())
        {

        }

        private Group group;

        public Group Group
        {
            get { return group; }
            set 
            { 
                group = value;
                RaisePropertyChanged(nameof(Group));          
            }
        }

    }
}
