using System;
using System.Collections.Generic;
using System.Text;

namespace CoreWPF.Model
{
    public class TodoItem
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsCompleted { get; set; }
        public DateTime CreatedDate { get; set; }
        public Category Category { get; set; }

        public string Color { get; set; }

    }
}
