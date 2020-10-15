using System;
using System.Collections.Generic;

namespace CoreWPF.Models
{
    public partial class TodoItems
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }

        public virtual Categories Category { get; set; }
    }
}
