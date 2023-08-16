using TaskManagment.Domain.Common;
using TaskManagment.Identity;

namespace TaskManagment.Domain
{
    public class Project : BaseDomainEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string OwnerId { get; set; }
        // Navigation properties
        public AppUser Owner { get; set; }
        public ICollection<Tasks> Tasks { get; set; }
        public ICollection<UserProject> UserProjects { get; set; }
    }
}
