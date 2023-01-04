using Microsoft.EntityFrameworkCore;
using SupinfoTours3.DAL;
using SupinfoTours3.Models;

namespace SupinfoTours3.Services
{
    public class BaseService<T>
    {
        private DbSchoolContext _context;

        public BaseService()
        {
            _context = new DbSchoolContext();
        }
        ~BaseService()
        {
            _context.Dispose();
        }

        public void Add(T item)
        {
            switch (item)
            {
                case Student s:
                    _context.Students.Add(s);
                    break;
                case Course c:
                    _context.Courses.Add(c);
                    break;
                case Address a:
                    _context.Addresses.Add(a);
                    break;
            }
            _context.SaveChanges();
        }

        public void Update(T item)
        {
            switch (item)
            {
                case Student s:
                    _context.Students.Update(s);
                    break;
                case Course c:
                    _context.Courses.Update(c);
                    break;
                case Address a:
                    _context.Addresses.Update(a);
                    break;
            }
            _context.SaveChanges();
        }
        /*
        public Student ReadOne(string name)
        {
            Student student = null;
            student = _context.Students.
                FirstOrDefault(student =>
                student.Name.ToLower() == name.ToLower());
            return student;
        }
        */
        public void Delete(T item)
        {
            switch (item)
            {
                case Student s:
                    _context.Students.Remove(s);
                    break;
                case Course c:
                    _context.Courses.Remove(c);
                    break;
                case Address a:
                    _context.Addresses.Remove(a);
                    break;
            }
            _context.SaveChanges();
        }
        /*
        public void DeleteByName(string name)
        {
            //Récupérer les étudiants devant être supprimés
            List<Student> studentsToDelete = new List<Student>();
            studentsToDelete = _context.Students
                .Where(s => s.Name.ToLower() == name.ToLower())
                .ToList();

            //Supprimer les étudiants listés
            for (int i = 0; i < studentsToDelete.Count; i++)
            {
                _context.Students.Remove(studentsToDelete[i]);
            }
            _context.SaveChanges();
        }
        */
        
       
    }
}
