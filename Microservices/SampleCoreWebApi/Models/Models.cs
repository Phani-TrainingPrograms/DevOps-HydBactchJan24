//Type of selection : Code File as it is an empty CS file 
//Install the following packages from the Nuget Package Manager:
//Microsoft.EntityFrameworkCore
//Microsoft.EntityFrameworkCore.SqlServer
//Microsoft.EntityFrameworkCore.Tools
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SampleCoreWebApi.Models
{
    [Table("tblEmployee", Schema ="dbo")]
    public class Employee
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [Column("empId")]
        public int EmpId { get; set; }

        [Column("empName")]
        public string EmpName { get; set; } = string.Empty;

        [Column("emailAddress")]
        public string EmailAddress { get; set; } = string.Empty;
        [Column("empSalary")]
        public int EmpSalary { get; set; }
    }

    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> dbOptions) :base(dbOptions) 
        {
            try
            {
                var dbCreator = Database.GetService<IDatabaseCreator>() as RelationalDatabaseCreator;
                if(dbCreator != null)
                {
                    if (!dbCreator.CanConnect()) dbCreator.Create();
                    if(!dbCreator.HasTables()) dbCreator.CreateTables();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DbSet<Employee> Employees { get; set; }
    }
}