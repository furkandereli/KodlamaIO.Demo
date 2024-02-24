using AutoMapper;
using KodlamaIO.Business.Abstract;
using KodlamaIO.Dto.InstructorDTOs;
using KodlamaIO.Entity.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KodlamaIO.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InstructorsController : ControllerBase
    {
        private readonly IInstructorService _instructorService;
        private readonly IMapper _mapper;

        public InstructorsController(IInstructorService instructorService, IMapper mapper)
        {
            _instructorService = instructorService;
            _mapper = mapper;
        }

        [HttpGet("GetInstructorList")]
        public IActionResult InstructorsList()
        {
            var value = _mapper.Map<List<ResultInstructorDto>>(_instructorService.GetAll());
            return Ok(value);
        }

        [HttpPost("CreateInstructor")]
        public IActionResult CreateInstructor(CreateInstructorDto createInstructorDto)
        {
            var value = _mapper.Map<Instructor>(createInstructorDto);
            _instructorService.Add(value);
            return Ok("Eğitmen oluşturuldu !");
        }

        [HttpPut("UpdateInstructor")]
        public IActionResult UpdateInstructor(UpdateInstructorDto updateInstructorDto)
        {
            var value = _mapper.Map<Instructor>(updateInstructorDto);
            _instructorService.Update(value);
            return Ok("Eğitmen güncellendi !");
        }

        [HttpGet("GetById")]
        public IActionResult GetById(int id)
        {
            var value = _instructorService.GetById(id);
            return Ok(value);
        }

        [HttpDelete("DeleteInstructor")]
        public IActionResult DeleteInstructor(int id)
        {
            var value = _instructorService.GetById(id);
            _instructorService.Delete(value);
            return Ok("Eğitmen silindi !");
        }
    }
}
