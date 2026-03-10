using System.ComponentModel.DataAnnotations;

namespace DemoMVC.Models.Student
{
    public class Student
    {
        [Key]
        [Required]
        public int Id { get; set; } = default;

        public string MSV { get; set; } = default!;

        public string FullName { get; set; } = default!;
    }
}