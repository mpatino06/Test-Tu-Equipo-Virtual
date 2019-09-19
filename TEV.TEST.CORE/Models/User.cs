using System;
using System.ComponentModel.DataAnnotations;

namespace TEV.TEST.CORE.Models
{
	public partial class User
	{
		[Key]
		public int Id { get; set; }
		public string LastName { get; set; }
		public string Address { get; set; }
		public DateTime CreateDate { get; set; }
		public DateTime UpdateDate { get; set; }
	}
}
