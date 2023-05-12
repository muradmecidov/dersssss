using Microsoft.EntityFrameworkCore;
using WebTask1.Models;

namespace WebTask1.DAL
{
	public class AppDbContex:DbContext
	{
		public AppDbContex(DbContextOptions<AppDbContex> options) : base(options)
		{

		}
		public DbSet<Group> Groups { get; set; }
		public DbSet<Student> Students { get; set; }
		public DbSet<Teacher> Teachers { get; set; }
		public DbSet<TeacherGroup> TeacherGroups { get; set; }
	}
}
