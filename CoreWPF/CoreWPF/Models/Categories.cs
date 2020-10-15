using System;
using System.Collections.Generic;

namespace CoreWPF.Models
{
    public partial class Categories
    {
        public Categories()
        {
            TodoItems = new HashSet<TodoItems>();
        }

        public int Id { get; set; }
        public string CategoryName { get; set; }
        public DateTime CreatedDate { get; set; }
        public string BackColor { get; set; }

        public virtual ICollection<TodoItems> TodoItems { get; set; }
    }
}
