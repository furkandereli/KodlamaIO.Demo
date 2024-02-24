using KodlamaIO.Business.Abstract;
using KodlamaIO.Business.Concrete;
using KodlamaIO.DataAccess.Abstract;
using KodlamaIO.DataAccess.EntityFramework;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIO.DataAccess.ServiceCollections
{
    public static class ServiceCollectionExtensions
    {
        public static void MyCollections(this IServiceCollection services)
        {
            services.AddScoped<ICategoryService, CategoryManager>();
            services.AddScoped<ICategoryDal, EfCategoryDal>();

            services.AddScoped<ICourseService, CourseManager>();
            services.AddScoped<ICourseDal, EfCourseDal>();

            services.AddScoped<IInstructorService, InstructorManager>();
            services.AddScoped<IInstructorDal, EfInstructorDal>();
        }
    }
}
