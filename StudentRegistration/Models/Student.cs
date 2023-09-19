using System.ComponentModel.DataAnnotations;

namespace StudentRegistration.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string Email { get; set; }
        public long Mobile { get; set; }
    }
}
