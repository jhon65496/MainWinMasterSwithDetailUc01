using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainWinMasterUcDetailUcSwithFrm02;
using MainWinMasterUcDetailUcSwithFrm02.ViewModels;

namespace MainWinMasterUcDetailUcSwithFrm02.Models
{
    public class Group
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public IList<Student> Students { get; set; } = new List<Student>();

        public string Description { get; set; }
    }
}
