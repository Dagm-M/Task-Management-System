using System.Collections.Generic;

namespace TaskManagment.Domain
{
    public class Label
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // Navigation properties
        public ICollection<TaskLabel> TaskLabels { get; set; }
    }
}
