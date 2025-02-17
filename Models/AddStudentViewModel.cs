using WebApplication1.Migrations;

namespace WebApplication1.Models
{
    public class AddStudentViewModel
    {
        public string?   Name { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public bool Subscribed { get; set; }

        public string? BloodGroup { get; set; }

        public string? Gender { get; set; }
    }
}
