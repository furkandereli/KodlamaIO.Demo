using AutoMapper;
using KodlamaIO.Business.Abstract;
using KodlamaIO.Dto.CourseDTOs;
using KodlamaIO.Entity.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KodlamaIO.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        private readonly ICourseService _courseService;
        private readonly IMapper _mapper;

        public CoursesController(ICourseService courseService, IMapper mapper)
        {
            _courseService = courseService;
            _mapper = mapper;
        }

        [HttpGet("GetCourseList")]
        public IActionResult CourseList()
        {
            var value = _mapper.Map<List<ResultCourseDto>>(_courseService.GetAll());
            return Ok(value);
        }

        [HttpPost("CreateCourse")]
        public IActionResult CreateCourse(CreateCourseDto createCourseDto)
        {
            var value = _mapper.Map<Course>(createCourseDto);
            _courseService.Add(value);
            return Ok("Kurs oluşturuldu !");
        }

        [HttpPut("UpdateCourse")]
        public IActionResult UpdateCourse(UpdateCourseDto updateCourseDto)
        {
            var value = _mapper.Map<Course>(updateCourseDto);
            _courseService.Update(value);
            return Ok("Kurs güncellendi !");
        }

        [HttpGet("GetById")]
        public IActionResult GetById(int id)
        {
            var value = _courseService.GetById(id);
            return Ok(value);
        }

        [HttpDelete("DeleteCourse")]
        public IActionResult DeleteCourse(int id)
        {
            var value = _courseService.GetById(id);
            _courseService.Delete(value);
            return Ok("Kurs silindi !");
        }
    }
}
