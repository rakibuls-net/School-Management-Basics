using System.ComponentModel.DataAnnotations;

namespace SchoolManagement.Models
{
    public class Teacher
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Subject { get; set; }

        public string Email { get; set; }
    }
    /*
     public enum Subject
    {
    bangla,
    english,
    Arabia,
    History,
    Meth
    
    }
     */
}
