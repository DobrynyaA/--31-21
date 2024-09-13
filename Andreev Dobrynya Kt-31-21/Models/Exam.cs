namespace Andreev_Dobrynya_Kt_31_21.Models
{
	public class Exam
	{
		public int ExamId { get; set; }
		public Subject Subject { get; set; }
		public int SubjectId { get; set; }
		public Student Student { get; set; }
		public int StudentId { get; set; }
		public int Mark { get; set; }
		public DateTime ExamDate { get; set; }
	}
}
