using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MVC_D2.Models
{
    public class Department
    {
        [Key]
        public int Id { get; set; }
        [MinLength(4, ErrorMessage = "At least 4 letters")]
        [MaxLength(50, ErrorMessage = "At Most 50 letters")]
        public string Name { get; set; }
        [MinLength(4,ErrorMessage ="At least 4 letters")]
        [MaxLength(50, ErrorMessage = "At Most 50 letters")]
        public string Manager { get; set; }
        public List<Student> Students { get; set; }
        public List<Course> Courses { get; set; }

        public List<Instructor> Instructors { get; set; }

    }
}
