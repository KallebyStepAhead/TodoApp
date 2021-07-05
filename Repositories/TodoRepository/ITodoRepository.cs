using System.Collections.Generic;
using ReactApp.Models;

namespace ReactApp.Repositories.TodoRepository
{
    interface ITodoRepository 
    {
        bool SaveChanges();
        TodoItem GetTodoItem(int id);

        IEnumerator<TodoItem> GetTodoItems();

        void CreateTodoItem(TodoItem todoItem);

        void UpdateTodoItem(TodoItem todoItem);

        void DeleteTodoItem(TodoItem todoItem);
    }
}