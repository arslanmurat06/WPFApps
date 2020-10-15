using System.Collections.Generic;

namespace WPFCore.DBLayer.Repository
{
    public interface ITodoRepository
    {
        List<Category> GetCategories();

        List<TodoItem> GetTodoItems();
    }
}