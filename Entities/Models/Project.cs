using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class Project
    {
        [Column("ProjectId")]
        public Guid Id { get; set; }
        
        [Required(ErrorMessage ="Project name is a required field.")]
        [MaxLength(60,ErrorMessage ="Maximum length of the name is 60 characters.")]
         public string  Name { get; set; }
        public string? Description { get; set; }
        public string? Field { get; set; }
        public string? ImageUrl { get; set; }

        public ICollection<Employee> Employees { get; set; }




    }
    public class Employee
    {
        [Column("EmployeeId")]
        public Guid Id { get; set; }
        [Required(ErrorMessage="FirstName is required")]
        public string FirstName { get; set; }
        [Required(ErrorMessage="LastName is required")]
        public string LastName { get; set; }
        public int Age { get; set; }
        public string? Position { get; set; }

        [ForeignKey(nameof(Project))]
        public Guid? ProjectId { get; set; }/* FK */
        public Project Project { get; set; }/* Navigation Property */
    }
}