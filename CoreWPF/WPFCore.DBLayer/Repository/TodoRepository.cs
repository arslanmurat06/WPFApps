using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFCore.DBLayer.Repository
{
    public class TodoRepository:ITodoRepository
    {
        public List<Category> GetCategories()
        {
            using (TodoModel context = new TodoModel())
            {
               return  context.Categories.ToList();
            }
        }

        public List<TodoItem> GetTodoItems()
        {
            using (TodoModel context = new TodoModel())
            {
                return context.TodoItems.ToList();
            }
        }

    }
}
