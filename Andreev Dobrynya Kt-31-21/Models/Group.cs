namespace Andreev_Dobrynya_Kt_31_21.Models
{
	using Microsoft.AspNetCore.Mvc.NewtonsoftJson;
	public class Group
	{
		public int GroupId { get; set; }
		public string GroupName { get; set; }
		public DateTime DateTime { get; set; }
		public string Speciality { get; set; }
		public ICollection<Student> Students { get; set; }
	}
}
