using AutoMapper;
using KodlamaIO.Dto.CategoryDTOs;
using KodlamaIO.Entity.Entities;

namespace KodlamaIO.WebApi.Mapping
{
    public class CategoryMapping : Profile
    {
        public CategoryMapping() 
        {
            CreateMap<Category, ResultCategoryDto>().ReverseMap();
            CreateMap<Category, CreateCategoryDto>().ReverseMap();
            CreateMap<Category, UpdateCategoryDto>().ReverseMap();
        }
    }
}
