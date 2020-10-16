using CoreWPF.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreWPF.Messages
{
    public class EditTodoItemMessage
    {
        public TodoItem TodoItem { get; set; }
        public EditTodoItemMessage(TodoItem todoItem )
        {
            TodoItem = todoItem;
        }
    }
}
