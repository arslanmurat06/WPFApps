using System;
using System.Collections.Generic;
using System.Text;

namespace CoreWPF.Models
{
    public interface IBaseEntity
    {
        DateTime CreatedDate { get; set; }
    }
}
