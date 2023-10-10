using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainWinMasterUcDetailUcSwithFrm02;
using MainWinMasterUcDetailUcSwithFrm02.ViewModels;

namespace MainWinMasterUcDetailUcSwithFrm02.Models
{
    public class Student
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Patronymic { get; set; }

        public DateTime Birthday { get; set; }

        public double Rating { get; set; }

        public string Description { get; set; }
    }
}
