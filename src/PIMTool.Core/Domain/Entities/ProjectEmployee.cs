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
        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int ProjectID {  get; set; }
        public int EmployeeID { get; set; }
    }
}
