using KodlamaIO.Business.Abstract;
using KodlamaIO.DataAccess.Abstract;
using KodlamaIO.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIO.Business.Concrete
{
    public class CourseManager : ICourseService
    {
        private readonly ICourseDal _courseDal;

        public CourseManager(ICourseDal courseDal)
        {
            _courseDal = courseDal;
        }

        public void Add(Course entity)
        {
            _courseDal.Add(entity);
        }

        public void Delete(Course entity)
        {
            _courseDal.Delete(entity);
        }

        public List<Course> GetAll()
        {
            return _courseDal.GetAll();
        }

        public Course GetById(int id)
        {
            return _courseDal.GetById(id);
        }

        public void Update(Course entity)
        {
            _courseDal.Update(entity);
        }
    }
}
