using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainWinMasterUcDetailUcSwithFrm02.Data;
using MainWinMasterUcDetailUcSwithFrm02.Models;

namespace MainWinMasterUcDetailUcSwithFrm02.Repositories
{
    public class GroupRepository
    {
        TestDataContext dataContext;
        
        public GroupRepository()
        {
            dataContext = new TestDataContext();

            GetAll();
        }


        public IEnumerable<Group> GetAll()
        {
            return dataContext.Groups;
        }
        
    }
}
