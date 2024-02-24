using AutoMapper;
using KodlamaIO.Dto.InstructorDTOs;
using KodlamaIO.Entity.Entities;

namespace KodlamaIO.WebApi.Mapping
{
    public class InstructorMapping : Profile
    {
        public InstructorMapping() 
        {
            CreateMap<Instructor, CreateInstructorDto>().ReverseMap();
            CreateMap<Instructor, ResultInstructorDto>().ReverseMap();
            CreateMap<Instructor, UpdateInstructorDto>().ReverseMap();
        }
    }
}
