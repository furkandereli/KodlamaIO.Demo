using AutoMapper;
using KodlamaIO.Business.Abstract;
using KodlamaIO.Dto.CategoryDTOs;
using KodlamaIO.Entity.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KodlamaIO.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;

        public CategoriesController(ICategoryService categoryService, IMapper mapper)
        {
            _categoryService = categoryService;
            _mapper = mapper;
        }

        [HttpGet("GetCategoryList")]
        public IActionResult CategoriesList()
        {
            var value = _mapper.Map<List<ResultCategoryDto>>(_categoryService.GetAll());
            return Ok(value);
        }

        [HttpPost("CreateCategory")]
        public IActionResult CreateCategory(CreateCategoryDto createCategoryDto)
        {
            var value = _mapper.Map<Category>(createCategoryDto);
            _categoryService.Add(value);
            return Ok("Kategori oluşturuldu !");
        }

        [HttpPut("UpdateCategory")]
        public IActionResult UpdateCategory(UpdateCategoryDto updateCategoryDto)
        {
            var value = _mapper.Map<Category>(updateCategoryDto);
            _categoryService.Update(value);
            return Ok("Kategori güncellendi !");
        }

        [HttpGet("GetById")]
        public IActionResult GetById(int id)
        {
            var value = _categoryService.GetById(id);
            return Ok(value);
        }

        [HttpDelete("DeleteCategory")]
        public IActionResult DeleteCategory(int id)
        {
            var value = _categoryService.GetById(id);
            _categoryService.Delete(value);
            return Ok("Kategori silindi !");
        }
    }
}
