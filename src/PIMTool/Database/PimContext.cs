using Microsoft.EntityFrameworkCore;
using PIMTool.Core.Domain.Entities;

namespace PIMTool.Database
{   
    //cho nay de define va tao cac Model tuong ung'

    public class PimContext : DbContext
    {
        // TODO: Define your models
        public DbSet<Project>? Projects { get; set; }
        public DbSet<Employee>? Employees { get; set; }

        public PimContext(DbContextOptions options) : base(options)
        {
        }

        //ctrl + dấu chấm: override hàm OnCreatingModel để tạo các Model tương ứng.
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            
            //tương tư các model còn lại
            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable("EMPLOYEE").HasKey(p => p.Id);
                entity.Property(p => p.Id).HasColumnName("ID");
                entity.Property(p => p.Visa).HasColumnName("VISA");
                entity.Property(p => p.FirstName).HasColumnName("FIRSTNAME");
                entity.Property(p => p.LastName).HasColumnName("LASTNAME");
                entity.Property(p => p.BirthDate).HasColumnName("BIRTH_DATE");
                entity.Property(p => p.Version).HasColumnName("VERSION");
            });
            modelBuilder.Entity<Group>(entity =>
            {
                entity.ToTable("GROUP").HasKey(p => p.Id);
                entity.Property(p => p.Id).HasColumnName("ID");
                entity.Property(p => p.GroupLeaderID).HasColumnName("GROUP_LEADER_ID");
                entity.Property(p => p.Version).HasColumnName("VERSION");
            } 
            );
            modelBuilder.Entity<Project>(entity =>
            {
                //na ná lệnh CREATE TALBE PROJECT, có primary key là ID
                entity.ToTable("PROJECT").HasKey(e => e.Id);
                //các lệnh sau là thêm cột
                entity.Property(p => p.Id).HasColumnName("ID");
                entity.Property(p => p.GroupId).HasColumnName("GROUP_ID");
                entity.Property(p => p.ProjectNumber).HasColumnName("PROJECT_NUMBER");
                entity.Property(p => p.Name).HasColumnName("NAME");
                entity.Property(p => p.Customer).HasColumnName("CUSTOMER");
                entity.Property(p => p.Status).HasColumnName("STATUS");
                entity.Property(p => p.StartDate).HasColumnName("START_DATE");
                entity.Property(p => p.EndDate).HasColumnName("END_DATE");
                entity.Property(p => p.Version).HasColumnName("VERSION");
                entity.HasOne<Group>(e => e.Group).WithMany(p => p.Projects).HasForeignKey(p => p.GroupId).OnDelete(DeleteBehavior.Restrict);
            });
            modelBuilder.Entity<ProjectEmployee>(entity =>
            {   
                entity.ToTable("PROJECT_EMPLOYEE");
                entity.Ignore(p => p.Id);
                entity.Property(p => p.ProjectID).HasColumnName("PROJECT_ID");
                entity.Property(p => p.EmployeeID).HasColumnName("EMPLOYEE_ID");
                entity.HasKey(e => new{ e.ProjectID, e.EmployeeID });
                entity.HasOne(e => e.Employee).WithMany(p => p.ProjectEmployees).HasForeignKey(p => p.EmployeeID);
                entity.HasOne(e => e.Project).WithMany(p => p.ProjectEmployees).HasForeignKey(p => p.ProjectID);
            });
        }


    }
}