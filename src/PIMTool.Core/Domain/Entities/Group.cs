using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PIMTool.Core.Domain.Entities
{
    public class Group : IEntity
    {
        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int GroupLeaderID { get; set; }
        public int[] Version { get; set; }
        public Employee Employee { get; set; }  
        public ICollection<Employee> Employees { get; set;}

    }
}
