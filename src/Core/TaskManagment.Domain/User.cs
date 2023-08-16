using Microsoft.AspNetCore.Identity;

namespace TaskManagment.Domain
{
    public class User : IdentityUser
    {
        // Navigation properties
        public ICollection<Project> OwnedProjects { get; set; }
        public ICollection<Tasks> CreatedTasks { get; set; }
        public ICollection<Tasks> AssignedTasks { get; set; }
        public ICollection<UserProject> UserProjects { get; set; }
    }
}
