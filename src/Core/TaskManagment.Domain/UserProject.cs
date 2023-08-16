using TaskManagment.Identity;

namespace TaskManagment.Domain
{
    public class UserProject
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public int ProjectId { get; set; }

        // Navigation properties
        public AppUser User { get; set; }
        public Project Project { get; set; }
    }
}
