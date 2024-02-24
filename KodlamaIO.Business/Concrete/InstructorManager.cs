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
    public class InstructorManager : IInstructorService
    {
        private readonly IInstructorDal _instructorDal;

        public InstructorManager(IInstructorDal instructorDal)
        {
            _instructorDal = instructorDal;
        }

        public void Add(Instructor entity)
        {
            _instructorDal.Add(entity);
        }

        public void Delete(Instructor entity)
        {
            _instructorDal.Delete(entity);
        }

        public List<Instructor> GetAll()
        {
            return _instructorDal.GetAll();
        }

        public Instructor GetById(int id)
        {
            return _instructorDal.GetById(id);
        }

        public void Update(Instructor entity)
        {
            _instructorDal.Update(entity);
        }
    }
}
