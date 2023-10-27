using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PIMTool.Core.Domain.Entities
{
    public class Employee : IEntity
    {
        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Visa { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public int[] Version { get; set; }
        public ICollection<ProjectEmployee> ProjectEmployees { get; set; }

        



    }
}
