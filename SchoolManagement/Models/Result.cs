namespace SchoolManagement.Models
{
    public class Result
    {
        public int Id { get; set; }

        public int StudentId { get; set; }
       
        public string Subject { get; set; }

        public int Marks { get; set; }

        public string Grade { get; set; }

        public virtual Student Student { get; set; }
    }
}
