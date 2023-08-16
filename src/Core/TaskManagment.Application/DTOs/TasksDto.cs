using TaskManagment.Application.DTOs.Common;

namespace TaskManagment.Application.DTOs
{
    public class TasksDto : BaseDto
    {
        public string Name { get; set; }
        public string Description { get; set; }

    }
}