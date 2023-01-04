// See https://aka.ms/new-console-template for more information
using SupinfoTours3.Models;
using SupinfoTours3.Services;


var studentService = new StudentsService();
var courseService = new CoursesService();
/*
var newCourse = new Course() { Name = "C#" };
newCourse.Students = new List<Student>();
newCourse.Students.Add(new Student() { Name = "Vincent" });
newCourse.Students.Add(new Student() { Name = "Sam" });
newCourse.Students.Add(new Student() { Name = "Flavie" });
*/
//courseService.Add(newCourse);

var course = courseService.ReadOneWithStudents("C#");
Console.WriteLine(course.Name);
Console.WriteLine(course.Students.Count);


