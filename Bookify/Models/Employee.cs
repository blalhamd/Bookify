namespace Bookify.Models
{
	public class Employee
	{
		public int Id { get; set; }
		public string Name { get; set; } = null!;
		public string SSN { get; set; } = null!;
        public int Level { get; set; }

    }
}
