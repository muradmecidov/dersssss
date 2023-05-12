namespace WebTask1.Models
{
	public class TeacherGroup
	{
		public string Id { get; set; }
		public int TeacherId { get; set; }
		public Teacher Teacher { get; set; }
		public Group Group { get; set; }
	}
}
