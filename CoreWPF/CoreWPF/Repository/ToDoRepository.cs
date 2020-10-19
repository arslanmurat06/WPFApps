using AutoMapper;
using CoreWPF.MapperProfile;
using CoreWPF.Model;
using CoreWPF.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreWPF.Repository
{
    public class ToDoRepository : IToDoRepository
    {
        IMapper _mapper;

        public ToDoRepository(IMapper mapper)
        {
            _mapper = mapper;
        }
        public List<IBaseModel> GetToDoItems()
        {
            using (ToDoContext context = new ToDoContext())
            {
                var todoItems = context.TodoItems.Include(a => a.Category).ToList();
                return todoItems.Select(t => _mapper.Map<TodoItem>(t) as IBaseModel).ToList();
            }
        }

        public List<IBaseModel> GetCategories()
        {
            using (ToDoContext context = new ToDoContext())
            {
                var categories = context.Categories.Include(t => t.TodoItems).ToList();
                return categories.Select(c => _mapper.Map<Category>(c) as IBaseModel).ToList();
            }
        }


        public List<IBaseModel> Save(List<IBaseModel> model)
        {
            IBaseEntity mappedEntity = null;
            List<IBaseEntity> returnedEntities = new List<IBaseEntity>();
            Type modelType = null;
            Type entityType;

            try
            {
                var toSave = model.Cast<IBaseModel>().ToList();

                if (model.Select(x => x.GetType())
                 .Distinct()
                 .Count() > 1)
                {
                    throw new Exception("Paramenter Dto must contain list of same type");
                }

                modelType = model.First().GetType();

                entityType = _mapper.ConfigurationProvider.GetAllTypeMaps()
                   .Where(x => x.SourceType == modelType)
                   .FirstOrDefault()
                   .DestinationType;

                using (ToDoContext context = new ToDoContext())
                {

                    foreach (var baseItem in model)
                    {

                        mappedEntity = _mapper.Map(baseItem, baseItem.GetType(), entityType) as IBaseEntity;
                        if (baseItem.ID == 0)
                        {
                            mappedEntity.CreatedDate = DateTime.UtcNow;
                            context.Add(mappedEntity);

                        }
                        returnedEntities.Add(mappedEntity);
                    }

                    context.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }
            return returnedEntities.Select(x => _mapper.Map(x, entityType, modelType) as IBaseModel).ToList();

        }


        public void Remove(IBaseModel removedItem)
        {
           using (var context = new ToDoContext())
            {
                var deletedEntity = _mapper.Map<TodoItems>(removedItem);
               context.Remove(deletedEntity);
                context.SaveChanges();
            }
            
        }

    }
}
