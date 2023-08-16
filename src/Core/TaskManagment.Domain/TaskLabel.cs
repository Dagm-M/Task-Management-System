namespace TaskManagment.Domain
{
    public class TaskLabel
    {
        public int Id { get; set; }
        public int TaskId { get; set; }
        public int LabelId { get; set; }

        // Navigation properties
        public Tasks Tasks { get; set; }
        public Label Label { get; set; }
    }
}
