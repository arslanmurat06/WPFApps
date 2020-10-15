using AutoMapper;
using CoreWPF.Model;
using CoreWPF.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreWPF.MapperProfile
{
    public class AutoMapperProfile: Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Categories, Category>();
            CreateMap<TodoItems, TodoItem>().ForMember(dest=> dest.Category,opts=> opts.MapFrom(src=>src.Category));
        }
    }
}
