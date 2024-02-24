using KodlamaIO.DataAccess.Abstract;
using KodlamaIO.DataAccess.Concrete;
using KodlamaIO.DataAccess.Repositories;
using KodlamaIO.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIO.DataAccess.EntityFramework
{
    public class EfInstructorDal : GenericRepository<Instructor>, IInstructorDal
    {
        public EfInstructorDal(KodlamaIOContext context) : base(context)
        {
        }
    }
}
