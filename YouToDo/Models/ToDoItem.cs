using System.ComponentModel.DataAnnotations;

namespace YouToDo.Models
{
    public class ToDoItem
    {
        [Required]
        public long Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public bool IsComplete { get; set; } = false;
    }
}
