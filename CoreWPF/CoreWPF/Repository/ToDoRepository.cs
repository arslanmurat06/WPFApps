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
    public class ToDoRepository: IToDoRepository
    {
        //AutoMapperProfile _mapper;
        IMapper _mapper;

        public ToDoRepository(IMapper mapper)
        {
            //_mapper = new AutoMapperProfile();
            _mapper = mapper;
        }
        public List<TodoItem> GetToDoItems()
        {
            using (ToDoContext context = new ToDoContext())
            {
                var todoItems = context.TodoItems.Include(a=>a.Category).ToList();
                return todoItems.Select(t => _mapper.Map<TodoItem>(t)).ToList();
            }
        }
    }
}
