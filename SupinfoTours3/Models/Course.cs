namespace SupinfoTours3.Models
{
	public class Course
	{
		public int CourseId { get; set; }
		public string Name { get; set; }

		public List<Student> Students { get; set; }
	}
}
