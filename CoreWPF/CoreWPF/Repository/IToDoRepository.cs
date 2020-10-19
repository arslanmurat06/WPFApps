using CoreWPF.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CoreWPF.Repository
{
    public interface IToDoRepository
    {
        List<IBaseModel> GetToDoItems();
        List<IBaseModel> GetCategories();
        List<IBaseModel> Save(List<IBaseModel> models);
        void Remove(IBaseModel removedItem);
    }
}