namespace WebAppTest.Models
{
    public class ToDoItem
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public ToDoStatus Status { get; set; }
    }
}
