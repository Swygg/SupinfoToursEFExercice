using Microsoft.EntityFrameworkCore;
using SupinfoTours3.DAL;
using SupinfoTours3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupinfoTours3.Services
{
    public class CoursesService : BaseService<Course>
    {
        private DbSchoolContext _context;

        public CoursesService()
        {
            _context = new DbSchoolContext();
        }
        ~CoursesService()
        {
            _context.Dispose();
        }

        public Course ReadOne(string name)
        {
            Course course = null;
            course = _context.Courses.
                FirstOrDefault(c =>
                c.Name.ToLower() == name.ToLower());
            return course;
        }

        public Course ReadOneWithStudents(string name)
        {
            Course course = null;
            course = _context.Courses
                .Include(course => course.Students)
                .FirstOrDefault(c => c.Name.ToLower() == name.ToLower());
            return course;
        }
    }
}
