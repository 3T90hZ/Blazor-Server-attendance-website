using AttendanceApp.Data;

namespace AttendanceApp.Models
{
    public class ClassSchedule
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public DateTime DateTime { get; set; }
        public string TeacherId { get; set; }
        public ApplicationUser Teacher { get; set; }
        public ICollection<AttendanceRecord> Attendances { get; set; }
    }
}
