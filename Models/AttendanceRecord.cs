using AttendanceApp.Data;

namespace AttendanceApp.Models
{
    public class AttendanceRecord
    {
        public int Id { get; set; }
        public string StudentId { get; set; }
        public ApplicationUser Student { get; set; }
        public int ClassScheduleId { get; set; }
        public ClassSchedule ClassSchedule { get; set; }
        public bool IsPresent { get; set; }
    }
}
