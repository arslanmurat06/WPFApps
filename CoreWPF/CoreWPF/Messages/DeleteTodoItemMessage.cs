using CoreWPF.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreWPF.Messages
{
    public class DeleteTodoItemMessage
    {
        public TodoItem TodoItem { get; set; }
        public DeleteTodoItemMessage(TodoItem todoItem)
        {
            TodoItem = todoItem;
        }
    }
}
