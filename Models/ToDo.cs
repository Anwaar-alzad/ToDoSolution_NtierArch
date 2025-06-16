using System.ComponentModel.DataAnnotations.Schema;

namespace ToDoSolution.Models
{
    public class Todo
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public TodoPiriority piriority { get; set; } = TodoPiriority.Medium;
        public bool IsCompeleted { get; set; } = false;
        public DateTime DueDate { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [ForeignKey("CategoryId")]  
        public Category Category { get; set; }
        public int CategoryId { get; set; }

    }
}
