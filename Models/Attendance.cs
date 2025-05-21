namespace EventEaseAppNew.Models
{
    public class Attendance
    {
        public string EventName { get; set; } = string.Empty;
        public string UserName { get; set; } = string.Empty;
        public DateTime RegistrationDate { get; set; } = DateTime.Now;
    }
}
