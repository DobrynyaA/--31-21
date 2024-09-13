namespace Andreev_Dobrynya_Kt_31_21.Models
{
	public class Test
	{
		public int TestId { get;set; }
		public Subject Subject { get; set; }
		public int SubjectId { get; set; }
		public Student Student { get; set; }
		public int StudentId { get; set;}
		public bool isPassed { get; set; }
		public DateTime TestDate { get; set; }
	}
}
