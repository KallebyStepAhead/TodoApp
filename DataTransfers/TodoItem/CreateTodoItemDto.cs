using System.ComponentModel.DataAnnotations;

namespace ReactApp.DataTransfers.TodoItem
{
    public class CreateTodoItemDto
    {
        [Required]
        [MaxLength(50)]
        public string Title { get; set; }

        [Required]
        [MaxLength(250)]
        public string Description { get; set; }
    }
}