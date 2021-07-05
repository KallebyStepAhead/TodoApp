using System.Linq;
using System.Collections.Generic;
using ReactApp.Database;
using ReactApp.Models;

namespace ReactApp.Repositories.TodoRepository
{
    public class TodoRepositoryImplementation : ITodoRepository
    {
        private readonly DataContext _context;

        public TodoRepositoryImplementation(DataContext context)
        {
            this._context = context;            
        }
        public void CreateTodoItem(TodoItem todoItem)
        {
            _context.TodoItems.Add(todoItem);
        }

        public void DeleteTodoItem(TodoItem todoItem)
        {
            _context.TodoItems.Remove(todoItem);
        }

        public TodoItem GetTodoItem(int id)
        {
            TodoItem todo = _context.TodoItems.FirstOrDefault(todo => todo.Id == id);

            return todo;
        }

        public IEnumerable<TodoItem> GetTodoItems()
        {
            List<TodoItem> todos = _context.TodoItems.ToList();

            return todos;
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() > 0);
        }

        public void UpdateTodoItem(TodoItem todoItem)
        {
            // Nothing
        }
    }
}