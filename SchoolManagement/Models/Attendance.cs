namespace SchoolManagement.Models
{
    public class Attendance
    {
        public int Id { get; set; }

        public int StudentId { get; set; }
       
        public DateTime Date { get; set; }

        public bool IsPresent { get; set; }

        public virtual Student Student { get; set; }
    }
}
