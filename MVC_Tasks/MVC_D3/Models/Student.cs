using Microsoft.AspNetCore.Cors.Infrastructure;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_D2.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Address { get; set; }

        public int Grade { get; set; }
        public string? ImageUrl { get; set; }

        [ForeignKey("Department")]
        public int? DepartmentId { get; set; }
        public Department? department { get; set; }

        public List<CourseResult> CourseResults { get; set; }


        
    }
}
