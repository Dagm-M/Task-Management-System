using TaskManagment.Application.DTOs.Common;

namespace TaskManagment.Application.DTOs
{
    public class ProjectDto : BaseDto
    {
        public string Name { get; set; }
        public string Description { get; set; }

    }
}