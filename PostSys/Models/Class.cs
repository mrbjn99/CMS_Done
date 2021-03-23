using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PostSys.Models
{
	public class Class
	{
		[Key]
		public int Id { get; set; }
		
		public string Name { get; set; }

		[DisplayName("Coordinator Name")]
		public string CoordinatorId { get; set; }
		public ApplicationUser Coordinator { get; set; }

		[DisplayName("Faculty Name")]
		public int FacultyId { get; set; }
		public Faculty Faculty { get; set; }

		[DisplayName("Enrollment Key")]
		public string EnrollmentKey { get; set; }
	}
}