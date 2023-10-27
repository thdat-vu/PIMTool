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
        public int Id { get ; set ; }
        public int GroupLeaderID { get; set; }
        public Byte[]? Version { get; set; }
        //public int[] Version {get; set;}
        public Employee? Employee { get; set; }  
        public ICollection<Project>? Projects { get; set;}

    }
}
