using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ReactApp.DataTransfers.TodoItem;
using ReactApp.Models;
using ReactApp.Repositories.TodoRepository;

namespace ReactApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TodoItemController: ControllerBase
    {
        private readonly ITodoRepository _repository;

        public TodoItemController(ITodoRepository repository)
        {
            this._repository = repository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<TodoItem>> GetAll()
        {
            var result = _repository.GetTodoItems();

            return Ok(result);
        }

        [HttpPost]
        public ActionResult<TodoItem> Create(CreateTodoItemDto data)
        {
            TodoItem todoItem = new TodoItem 
            {
                Title = data.Title,
                Description = data.Description
            };

            _repository.CreateTodoItem(todoItem);
            _repository.SaveChanges();

            return Ok(todoItem);
        }
    }
}