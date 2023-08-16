using System.ComponentModel.DataAnnotations;
using TaskManagment.Domain.Common;
using TaskManagment.Identity;

namespace TaskManagment.Domain
{
    public enum TaskStatus
    {
        ToDo,
        InProgress,
        Done
    }

    public enum TaskPriority
    {
        Low,
        Medium,
        High
    }

    public class Tasks : BaseDomainEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public TaskStatus Status { get; set; }
        public TaskPriority Priority { get; set; }
        public string CreatorId { get; set; }
        public string AssignedUserId { get; set; }
        public int ProjectId { get; set; }

        // Navigation properties
        public AppUser Creator { get; set; }
        public AppUser AssignedUser { get; set; }
        public Project Project { get; set; }
        public ICollection<TaskLabel> TaskLabels { get; set; }
    }
}
