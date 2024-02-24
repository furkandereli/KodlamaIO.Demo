using AutoMapper;
using KodlamaIO.Dto.CourseDTOs;
using KodlamaIO.Entity.Entities;

namespace KodlamaIO.WebApi.Mapping
{
    public class CourseMapping : Profile
    {
        public CourseMapping() 
        {
            CreateMap<Course, CreateCourseDto>().ReverseMap();
            CreateMap<Course, ResultCourseDto>().ReverseMap();
            CreateMap<Course, UpdateCourseDto>().ReverseMap();
        }
    }
}
