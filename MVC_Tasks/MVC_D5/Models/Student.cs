using Microsoft.AspNetCore.Cors.Infrastructure;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MVC_D2.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [MinLength(4, ErrorMessage = "At least 4 letters")]
        [MaxLength(50, ErrorMessage = "At Most 50 letters")]
        public string Name { get; set; }
        [MinLength(4, ErrorMessage = "At least 4 letters")]
        [MaxLength(200, ErrorMessage = "At Most 200 letters")]
        public string? Address { get; set; }

        public int? Grade { get; set; }
        public string? ImageUrl { get; set; }

        [ForeignKey("Department")]
        [DisplayName("Department")]
        public int? DepartmentId { get; set; }
        public Department? department { get; set; }

        public List<CourseResult>? CourseResults { get; set; }


        
    }
}
