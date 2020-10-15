using CoreWPF.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CoreWPF.Repository
{
    public interface IToDoRepository
    {
        List<TodoItem> GetToDoItems();
    }
}