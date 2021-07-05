using System.Collections.Generic;
using ReactApp.Models;

namespace ReactApp.Repositories.TodoRepository
{
    public interface ITodoRepository 
    {
        bool SaveChanges();
        TodoItem GetTodoItem(int id);

        IEnumerable<TodoItem> GetTodoItems();

        void CreateTodoItem(TodoItem todoItem);

        void UpdateTodoItem(TodoItem todoItem);

        void DeleteTodoItem(TodoItem todoItem);
    }
}