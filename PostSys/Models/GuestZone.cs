namespace PostSys.Models
{
	public class GuestZone
	{
		public int Id { get; set; }
		public string Name { get; set; }

		public string GuestId { get; set; }
		public ApplicationUser Guest { get; set; }

		public int FacultyId { get; set; }
		public Faculty Faculty { get; set; }
	}
}