using System.ComponentModel.DataAnnotations;

namespace PIMTool.Core.Domain.Entities
{
    public class Project : IEntity
    {
        public int Id { get; set; }

        [MaxLength(255)]
        public int GroupId { get; set; }
        public int ProjectNumber { get; set; }
        public string Name { get; set; } = null!;
        public string Customer { get; set; }
        public string Status { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; } 
        public int[] Version {  get; set; }
        public Group Group { get; set; }
        public ICollection <ProjectEmployee> ProjectEmployees { get; set; }

    }
}