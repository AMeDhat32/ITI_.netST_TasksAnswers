using System.ComponentModel.DataAnnotations;

namespace MVC_Study.Models
{
    public class Student
    {
        [Key]
        public int SSN { get; set;}
        public string Name { get; set;}
        public int Age { get; set;}

     
        public string PhoneNumber { get; set;}
    }
}
