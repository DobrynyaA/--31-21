namespace Andreev_Dobrynya_Kt_31_21.Models
{
	public class Group
	{
		public int GroupId { get; set; }
		public string GroupName { get; set; }
		public DateOnly Date { get; set; }
		public string Speciality { get; set; }
		public ICollection<Student> Students { get; set; }
	}
}
