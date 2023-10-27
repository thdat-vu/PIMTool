using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PIMTool.Core.Domain.Entities
{
    public class ProjectEmployee : IEntity
    {
        public int Id { get; set; }
        public int ProjectID {  get; set; }
        public int EmployeeID { get; set; }
        public Employee? Employee { get; set; }
        public Project? Project { get; set; }    
    }
}
