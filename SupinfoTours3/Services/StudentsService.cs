using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SupinfoTours3.DAL;
using SupinfoTours3.Models;

namespace SupinfoTours3.Services
{
    public class StudentsService : BaseService<Student>
    {
        private DbSchoolContext _context;

        public StudentsService()
        {
            _context = new DbSchoolContext();
        }
        ~StudentsService()
        {
            _context.Dispose();
        }

        public Student ReadOne(string name)
        {
            Student student = null;
            student = _context.Students.
                FirstOrDefault(student =>
                student.Name.ToLower() == name.ToLower());
            return student;
        }

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

        public List<Student> Generate()
        {
            return new List<Student>()
            {
                new Student(){ Name ="Jean"},
                new Student(){ Name ="Jack"},
                new Student(){ Name ="Pierre"},
                new Student(){ Name ="Flavie"},
                new Student(){ Name ="Flora"},
                new Student(){ Name ="Henry"},
                new Student(){ Name ="Gérard"},
                new Student(){ Name ="Jean"},
                new Student(){ Name ="Zazi"},
                new Student(){ Name ="Monique"},
            };
        }
    }
}
