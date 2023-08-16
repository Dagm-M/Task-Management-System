using Microsoft.AspNetCore.Identity;
using TaskManagment.Domain;

namespace TaskManagment.Identity
{
    public class AppUser : IdentityUser
    {
        // Additional properties if needed

        // Navigation properties
        public ICollection<Project> OwnedProjects { get; set; }
        public ICollection<Tasks> CreatedTasks { get; set; }
        public ICollection<Tasks> AssignedTasks { get; set; }
        public ICollection<UserProject> UserProjects { get; set; }
    }
}
