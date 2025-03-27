using AttendanceApp.Data;

namespace AttendanceApp.Models
{
    public class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string TeacherId { get; set; }
        public ApplicationUser Teacher { get; set; }
    }
}
