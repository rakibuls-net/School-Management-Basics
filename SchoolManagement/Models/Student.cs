using System.ComponentModel.DataAnnotations;

namespace SchoolManagement.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required]

        public string Name { get; set; }

        [Required]
        public string Class { get; set; }

        [Required]
        public int Roll { get; set; }

        public DateTime DOB { get; set; }
    }
    /*
    public enum Class
    {
        One,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten

    }
    */
}
